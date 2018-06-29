import { Component, OnInit } from '@angular/core';
import { Http } from '@angular/http'
import { DataService } from "../services/data.services";
//import DataService = Dataservices.DataService;

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  constructor(private httpService: Http) { }
  apiValues: string[] = [];
  ngOnInit() {
    let dataService: DataService = new DataService(this.httpService);
    dataService.returnValues().then((data) => {
      this.apiValues = data;
    }).catch((error) => {
      console.log("An unknown error occured while returning values: " + error);
    });
  }
}
