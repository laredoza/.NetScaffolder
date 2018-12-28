# Generated .NetScaffolder WebApi

### Migrations 

rem go to correct project
rem Open Pckage Manager
cd  Data\Migrations\EFCore\SqlServer
rem Save Migration
dotnet ef migrations add --startup-project RepositoryEFDotnet.Data.Migrations.SqlServer.csproj --project ..\..\..\Contexts\EFCore\SqlServer\RepositoryEFDotnet.Contexts.EFCore.SqlServer.csproj --context RepositoryEFDotnet.Data.Context.EFCore.SqlServerFullContext 'Initial'
rem Update Database
dotnet ef database updat
