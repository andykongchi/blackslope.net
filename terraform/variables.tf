variable "aws_region" {
  default     = "us-east-1"
  description = "AWS Region (e.g. us-east-1)"
}

variable "aurora_master_username" {
  default     = "blackslope_user"
  description = "Aurora Cluster Master Username"
}

variable "aurora_master_password" {
  description = "Aurora Cluster Master Password"
}

variable "tags_purpose" {
  default     = "Blackslope.net"
  description = "Purpose for deployment (tag value)"
}

variable "tags_owner" {
  description = "Owner of deployment (tag value)"
}

variable "tags_email" {
  description = "Deployment owner's email (tag value)"
}

variable "security_group_inbound_outbound_ip_cidr" {
  default     = ["0.0.0.0/0"]
  description = "Security Group Inbound and Outbound IP CIDR blocks"
}
