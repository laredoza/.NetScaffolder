# .NetScaffolder

### Simple, highly flexible scaffolding framework based on T4 Scripts

The aim of this project will be to quickly generate a base project from a data model. The initial aim will be to generate a MVC project with datacontexts, ef entities (or nHibernate) & presentation layer. The next will be to generate a repository layer. These will then later be combined into a Domain Driven application.

If for whatever reason you don't like our implementations of any of the layers it should be pretty easy to modify / create your own.

### The data model will be generated by importing data from the following sources:

- Edmx Files
- MSSql Metadata
- Oracle Metadata
- Extendable Custom sources

This imported data will then be saved in a xml file (.mdl). All generation will then be based on this file.
This project file will contain domains. A domain will contain several tables ( These are imported from the data sources ). These tables are used to generate the different layers. i.e) Security Domain with a user table and a role table, etc.

T4 templates will be used to generate the different layers. Packages consist of several templates. A domain will be set to use a package to generate all it's layers.  

### Generated Project Types:

- MVC (Context, Entities (Entity Framework / NHibernate entity) & Presentation)
- MVC (Context, Entities (Entity Framework / NHibernate entity), Repository & Presentation)
- MVC (Domain Driven - Entity Framework / NHibernate)

### Todo
- [0.3 Create .NET base repository for EF 6](https://github.com/laredoza/.NetScaffolder/milestone/3)
- [0.4 Create .NET Core base repository for EF Core](https://github.com/laredoza/.NetScaffolder/milestone/4)
- [0.5 Create base repository for nHibernate](https://github.com/laredoza/.NetScaffolder/milestone/5)
- [0.6 Create Application Service](https://github.com/laredoza/.NetScaffolder/milestone/6)
- [0.7 Create Dto's](https://github.com/laredoza/.NetScaffolder/milestone/7)
- [0.71 Create base repository for MySql](https://github.com/laredoza/.NetScaffolder/milestone/9)
- [0.8 Create MVC Presentation Layer & ModelViews](https://github.com/laredoza/.NetScaffolder/milestone/8)
- [0.9 Stabilization](https://github.com/laredoza/.NetScaffolder/milestone/12)
- [1.0 Create Angular Presentation Layer & ModelViews](https://github.com/laredoza/.NetScaffolder/milestone/10)
- [1.1 Create Xamarin Presentation Layer & ModelView](https://github.com/laredoza/.NetScaffolder/milestone/11)

### Software Requirements
- [Visual Studio](https://www.visualstudio.com/downloads/)
- [T4 Toolbox](https://marketplace.visualstudio.com/items?itemName=OlegVSych.T4ToolboxforVisualStudio2017)

### Formating T4
- [Devart T4 Editor](https://www.devart.com/t4-editor/download.html)
