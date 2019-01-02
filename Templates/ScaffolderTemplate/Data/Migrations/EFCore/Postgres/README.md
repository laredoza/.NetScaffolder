# Postgres Migrations 

- Go to correct project 
Open Package Manager
cd  Data\Migrations\EFCore\Postgres
- Save Migration (if required)
dotnet ef migrations add --startup-project DotNetScaffolder.Domain.Migrations.EFCore.Postgres.csproj --project ..\..\..\Contexts\EFCore\Postgres\DotNetScaffolder.Domain.Data.Contexts.EFCore.Postgres.csproj --context DotNetScaffolder.Domain.Data.Contexts.EFCore.Postgres.Context.PostgresFullContext 'Initial'
- Update Database
dotnet ef database update