# BlackSlope.NET

## What is it?

You can read more in the following blog posts:

* https://medium.com/slalom-build/introducing-black-slope-a-dotnet-core-reference-architecture-from-slalom-build-3f1452eb62ef
* https://medium.com/slalom-engineering/black-slope-setup-and-insights-e05ab58e2960

## Installation Instructions

### Install .NET Core
Install the latest verison of .NET Core for Windows/Linux or Mac.
* https://dotnet.microsoft.com/download

### Build (Application)

	dotnet build src/BlackSlope.NET.sln

### Build (Database)

1. Install SQL Server Developer 2019
    > https://www.microsoft.com/en-us/sql-server/sql-server-downloads
2. Update connection string server name and credentials in [appsettings.json](./src/BlackSlope.Api/appsettings.json)
    ```
    MoviesConnectionString
    ```
3. Open PowerShell to your repository root directory and run the following command:
    ```
    dotnet ef database update --project src/BlackSlope.Api/BlackSlope.Api.csproj
    ```
4. If successful, the result of the above command will be similar to the following example:
    ```
    Build started...
    Build succeeded.
    Applying migration <...>
    Done.
    ```

### Run

	dotnet run --project src/BlackSlope.Api/BlackSlope.Api.csproj

### Test

    dotnet test ./src/

### Swagger
Open your browser and navigate to ```http://localhost:51385/swagger``` to view the API documentation

### StyleCop
The following rules are currently ignored.

| Rule Id | Rule Title |
| --- | --- |
| SA1101 | Prefix local calls with this |
| SA1309 | Field names should not begin with an underscore |
| SA1629 | Documentation text should end with a period |
| SA1633 | File should have header |
| SA1600 | Elements should be documented |
| SA1614 | Element parameter documentation must have text |
| SA1616 | Element return value documentation must have text |

### Terraform
1. `cd terraform`
2. Add _local.auto.tfvars in terraform file (recommended) or apply variables via CLI manually
```
aurora_master_password                  = ""
tags_owner                              = "Your name"
tags_email                              = "your@email.com"
tags_purpose                            = "Blackslope db environment"
security_group_inbound_outbound_ip_cidr = ["your_ip_address/32"]

```
3. `terraform plan`
4. `terraform apply`

### Flyway
1. Setup flyway.conf in flyway installation `/conf` directory
2. `flyway migrate -locations="filesystem:flyway/sql"`

### Liquibase
1. `liquibase --url="jdbc:postgresql://update_host_here:5432/blackslope" --username="blackslope_user" --password="<password or update liquibase.properties>" update`