# SqlServer Migrations 

- Go to correct project 
Open Package Manager
cd  Data\Migrations\EFCore\SqlServer
- Save Migration (if required)
dotnet ef migrations add --startup-project RepositoryEFDotnet.Data.Migrations.SqlServer.csproj --project ..\..\..\Contexts\EFCore\SqlServer\RepositoryEFDotnet.Contexts.EFCore.SqlServer.csproj --context RepositoryEFDotnet.Data.Context.EFCore.SqlServerFullContext 'Initial'
- Update Database
dotnet ef database update