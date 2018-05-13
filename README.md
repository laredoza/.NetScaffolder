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

- Edmx Files
- MySql Metadata
- Oracle Metadata
- Sql Server Metadata
- Extendable Custom sources

Imported data is saved in a model file (.mdl) which is then used to generate the different layers.

T4 templates (DataTypes) are used to generate a layer. Packages group several of these templates together. A domain will be set to use a package to generate the required layers.

### Supported Database Drivers

- Entity Famework 6.0 ( MySql, Sql Server, Oracle)
- Adding support for Entity Framework Core
- Adding support for NHibernate

### Planned Project Types:

- MVC
- Angular 
- Xamarin

### Completed
- ~~[0.2 Basic UI Management](https://github.com/laredoza/.NetScaffolder/milestone/2)~~
- ~~[0.31 Create Dto's](https://github.com/laredoza/.NetScaffolder/milestone/7)~~
- ~~[0.32 Create base repository for MySql](https://github.com/laredoza/.NetScaffolder/milestone/9)~~

### Todo
- [0.3 Create .NET base repository for EF 6](https://github.com/laredoza/.NetScaffolder/milestone/3)
- [0.4 Create .NET Core base repository for EF Core](https://github.com/laredoza/.NetScaffolder/milestone/4)
- [0.5 Create base repository for nHibernate](https://github.com/laredoza/.NetScaffolder/milestone/5)
- [0.6 Create Application Service](https://github.com/laredoza/.NetScaffolder/milestone/6)
- [0.8 Create MVC Presentation Layer & ModelViews](https://github.com/laredoza/.NetScaffolder/milestone/8)
- [0.7 Stabilization](https://github.com/laredoza/.NetScaffolder/milestone/12)
- [1.0 Create Angular Presentation Layer & ModelViews](https://github.com/laredoza/.NetScaffolder/milestone/10)
- [1.1 Create Xamarin Presentation Layer & ModelView](https://github.com/laredoza/.NetScaffolder/milestone/11)

### Software Requirements
- [Visual Studio](https://www.visualstudio.com/downloads/)
- [T4 Toolbox](https://marketplace.visualstudio.com/items?itemName=OlegVSych.T4ToolboxforVisualStudio2017)

### Useful Tools
- [Devart T4 Editor](https://www.devart.com/t4-editor/download.html)
