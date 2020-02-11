provider "aws" {
  region = var.aws_region
}

resource "aws_vpc" "blackslope_main" {
  cidr_block = "10.0.0.0/16"

  tags = {
    Owner   = var.tags_owner
    Email   = var.tags_email
    Purpose = var.tags_purpose
  }
}

resource "aws_subnet" "blackslope_main-public-1" {
  vpc_id                  = aws_vpc.blackslope_main.id
  cidr_block              = "10.0.1.0/24"
  map_public_ip_on_launch = true

  tags {
    Owner   = var.tags_owner
    Email   = var.tags_email
    Purpose = var.tags_purpose
  }
}

resource "aws_db_subnet_group" "aurora_subnet_group" {
  name       = "blackslope_aurora_subnet_group"
  subnet_ids = [aws_subnet.blackslope_main-public-1.id]

  tags = {
    Owner   = var.tags_owner
    Email   = var.tags_email
    Purpose = var.tags_purpose
  }
}

resource "aws_security_group" "allow_postgres" {
  name        = "allow_postgres"
  description = "Allow Postgres inbound traffic"
  vpc_id      = aws_vpc.blackslope_main.id

  ingress {
    from_port   = 0
    to_port     = 0
    protocol    = "-1"
    cidr_blocks = ["0.0.0.0/0"]
  }

  egress {
    from_port   = 0
    to_port     = 0
    protocol    = "-1"
    cidr_blocks = ["0.0.0.0/0"]
  }
}

resource "aws_rds_cluster" "postgres_cluster" {
  cluster_identifier     = "blackslope-cluster-pg"
  engine                 = "aurora-postgresql"
  database_name          = "blackslope"
  master_username        = "blackslope_user"
  master_password        = var.aurora_master_password
  vpc_security_group_ids = [aws_security_group.allow_postgres.id]
  db_subnet_group_name   = 

  tags = {
    Owner   = var.tags_owner
    Email   = var.tags_email
    Purpose = var.tags_purpose
  }
}

resource "aws_rds_cluster_instance" "cluster_instances" {
  count               = 1
  identifier          = "blackslope-aurora-${count.index}"
  cluster_identifier  = aws_rds_cluster.postgres_cluster.id
  engine              = "aurora-postgresql"
  instance_class      = "db.t3.medium" # See pricing at: https://aws.amazon.com/rds/aurora/pricing/
  publicly_accessible = true

  tags = {
    Owner   = var.tags_owner
    Email   = var.tags_email
    Purpose = var.tags_purpose
  }
}
