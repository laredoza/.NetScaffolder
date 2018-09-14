# .NetScaffolder - Angular Application

### Angular application generated from a Model based on T4 Scripts

.NetScaffolder generates an Angular(https://cli.angular.io/) project from a data model by using easily extendable templates. 

### Run application

Press F5. This will run the application with the latest built Angular application (http://localhost:49685/). This starts both the webapi as well as the Angular application.

### Developing and debugging the Angular application

Press F5. This will run the application with the latest built Angular application (http://localhost:49685/). At this point we're only interested in the WebApi.

cd Api/Angular
npm run proxy

The website can now be accessed at the address http://localhost:4200/. Any changes made to the Angular application will be seen immediately.

### Build

npm run build

This copies files to ../wwwroot
