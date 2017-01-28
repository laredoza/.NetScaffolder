# .NetScaffolder

Simple, highly flexible scaffolding framework based on T4 Scripts

The aim of this project will be to quickly generate a base project from a data model. The initial aim will be to generate a MVC/WPF project with datacontexts, ef entities & presentation layer. The next will be to generate a repository layer. These will then later be combined into a Domain Driven application. 

#The data model will be generated by importing data from the following sources:#

- .Edmx Files
- MSSql Metadata
- Oracle Metadata
- Oracle Data Modeller

This imported data will then be saved in a xml file (.mdl). All generation will then be based on this file.

#Generated Project Types:#

- MVC (context, ef models & presentation)
- WPF (context, ef models & presentation)
- MVC (context, ef models, repository & presentation)
- WPF (context, ef models, repository & presentation)
- MVC (Domain Driven)
- WPF (Domain Driven)
- The above using MongoDb








