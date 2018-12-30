# .NetScaffolder

### Simple, highly flexible scaffolding framework based on T4 Scripts

.NetScaffolder generates a project from a data model by using easily extendable templates. 

### The default data layers consists of the following:

- Context ( Entity Framework 6.0 / Entity Framework Core / NHibernate)
- Entities
- Repository Layer
- Application Service
- Dto

Additions and modifications are easily made to these layers.

### The data model will be generated by importing data from the following sources:

- Edmx Files ( No index data is available )
- MySql Metadata ( Version 5.7 - Known issues with version 8)
- Oracle Metadata
- Sql Server Metadata
- PostgreSQL ( Planned )
- Extendable Custom sources

The [Scaffolder Application](https://github.com/laredoza/.NetScaffolder/blob/master/src/DotNetScaffolder.sln) is used to import and manage models.

Imported data is saved in a [model file](https://github.com/laredoza/.NetScaffolder/blob/master/Templates/Generated/Dal/Repository/EF/Dotnet/Data/Repositories/Repository/Model/Banking.mdl) which is then used to generate the different layers.

An example of a [generated data layer](https://github.com/laredoza/.NetScaffolder/blob/master/Templates/Generated/Dal/Repository/EF/Dotnet/RepositoryEFDotnet.sln) is included. Save [RunGenerator.tt](https://github.com/laredoza/.NetScaffolder/blob/master/Templates/Generated/Dal/Repository/EF/Dotnet/Data/Repositories/Repository/RunGenerator.tt) to cause a rebuild of the data layers. 

T4 templates (DataTypes) are used to generate a layer. Packages group several of these templates together. A domain will be set to use a package to generate the required layers.

### Supported Database Drivers

- Entity Famework 6.0 ( MySql, Sql Server, Oracle, PostgreSQL )
- Entity Framework Core 2.1 ( MySql - Pomelo Driver, Sql Server )
- NHibernate ( Mysql, Sql Server, Oracle )

### Generated Project Types:

- WebApi

### Planned Project Types:

- MVC
- Angular 
- Xamarin

### Documentation

[.NetScaffolder Manual](https://github.com/laredoza/.NetScaffolder/blob/master/Documentation/Manual.pdf)

### Completed
- ~~[0.2 Basic UI Management](https://github.com/laredoza/.NetScaffolder/milestone/2)~~
- ~~[0.3 Create .NET base repository for EF 6](https://github.com/laredoza/.NetScaffolder/milestone/3)~~
- ~~[0.31 Create Dto's](https://github.com/laredoza/.NetScaffolder/milestone/7)~~
- ~~[0.32 Create base repository for MySql](https://github.com/laredoza/.NetScaffolder/milestone/9)~~
- ~~[0.4 Create .NET Core base repository for EF Core](https://github.com/laredoza/.NetScaffolder/milestone/4)~~
- ~~[0.5 Create base repository for nHibernate](https://github.com/laredoza/.NetScaffolder/milestone/5)~~
- ~~[0.6 Create Application Service](https://github.com/laredoza/.NetScaffolder/milestone/6)~~

### Todo
- [Data Stabilization](https://github.com/laredoza/.NetScaffolder/milestone/12)
- [0.7 Services](https://github.com/laredoza/.NetScaffolder/milestone/13)
- [0.8 Create MVC Presentation Layer & ModelViews](https://github.com/laredoza/.NetScaffolder/milestone/8)
- [0.81 Create Angular Presentation Layer & ModelViews](https://github.com/laredoza/.NetScaffolder/milestone/10)
- [0.82 Create Xamarin Presentation Layer & ModelView](https://github.com/laredoza/.NetScaffolder/milestone/11)

### Software Requirements
- [Visual Studio](https://www.visualstudio.com/downloads/)
- [T4 Toolbox](https://marketplace.visualstudio.com/items?itemName=OlegVSych.T4ToolboxforVisualStudio2017)

### Useful Tools
- [Devart T4 Editor](https://www.devart.com/t4-editor/download.html)

### Known Issues
- Please retrieve source code by using a git clone instead of downloading the project's zip as this causes T4 security issues. We will look for work arounds at a later stage.
- EF Migrations won't work until version EF 6.3 is released as migrations don't support the new project types 
