provider "aws" {
  region = var.aws_region
}

resource "aws_vpc" "blackslope_main" {
  cidr_block           = "10.0.0.0/16"
  enable_dns_support   = true
  enable_dns_hostnames = true

  tags = {
    Owner   = var.tags_owner
    Email   = var.tags_email
    Purpose = var.tags_purpose
  }
}

resource "aws_internet_gateway" "gw" {
  vpc_id = aws_vpc.blackslope_main.id

  tags = {
    Owner   = var.tags_owner
    Email   = var.tags_email
    Purpose = var.tags_purpose
  }
}

resource "aws_route_table" "public" {
  count  = 1
  vpc_id = aws_vpc.blackslope_main.id

  tags = {
    Owner   = var.tags_owner
    Email   = var.tags_email
    Purpose = var.tags_purpose
  }
}

resource "aws_route" "public_internet_gateway" {
  count                  = 1
  route_table_id         = aws_route_table.public[0].id
  destination_cidr_block = "0.0.0.0/0"
  gateway_id             = aws_internet_gateway.gw.id
  timeouts {
    create = "5m"
  }
}
resource "aws_route" "public_internet_gateway_ipv6" {
  count                       = 1
  route_table_id              = aws_route_table.public[0].id
  destination_ipv6_cidr_block = "::/0"
  gateway_id                  = aws_internet_gateway.gw.id
}

resource "aws_main_route_table_association" "a" {
  vpc_id         = aws_vpc.blackslope_main.id
  route_table_id = aws_route_table.public[0].id
}

resource "aws_subnet" "blackslope_main-public-1" {
  availability_zone       = "${var.aws_region}a"
  vpc_id                  = aws_vpc.blackslope_main.id
  cidr_block              = "10.0.1.0/24"
  map_public_ip_on_launch = true

  tags = {
    Owner   = var.tags_owner
    Email   = var.tags_email
    Purpose = var.tags_purpose
  }
}

resource "aws_subnet" "blackslope_main-public-2" {
  availability_zone       = "${var.aws_region}b"
  vpc_id                  = aws_vpc.blackslope_main.id
  cidr_block              = "10.0.2.0/24"
  map_public_ip_on_launch = true

  tags = {
    Owner   = var.tags_owner
    Email   = var.tags_email
    Purpose = var.tags_purpose
  }
}

resource "aws_db_subnet_group" "aurora_subnet_group" {
  name       = "blackslope_aurora_subnet_group"
  subnet_ids = [aws_subnet.blackslope_main-public-1.id, aws_subnet.blackslope_main-public-2.id]

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
    cidr_blocks = var.security_group_inbound_outbound_ip_cidr
  }

  egress {
    from_port   = 0
    to_port     = 0
    protocol    = "-1"
    cidr_blocks = var.security_group_inbound_outbound_ip_cidr
  }

  tags = {
    Owner   = var.tags_owner
    Email   = var.tags_email
    Purpose = var.tags_purpose
  }
}

resource "aws_rds_cluster" "postgres_cluster" {
  cluster_identifier        = "blackslope-cluster-pg"
  engine                    = "aurora-postgresql"
  database_name             = "blackslope"
  master_username           = var.aurora_master_username
  master_password           = var.aurora_master_password
  vpc_security_group_ids    = [aws_security_group.allow_postgres.id]
  db_subnet_group_name      = aws_db_subnet_group.aurora_subnet_group.name
  final_snapshot_identifier = "blackslope-aurora-final-snapshot"

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
