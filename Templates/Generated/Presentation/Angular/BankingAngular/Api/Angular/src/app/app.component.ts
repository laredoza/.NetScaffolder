import { ChangeDetectorRef, Component, OnInit, OnDestroy } from '@angular/core';
import { Http } from '@angular/http'
import { DataService } from "../services/data.services";

import { MediaMatcher } from '@angular/cdk/layout';

// https://stackblitz.com/angular/aydrrdqnrjk?file=app%2Fsidenav-responsive-example.ts

  @Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {

  mobileQuery: MediaQueryList;
  links: Array<{ text: string, path: string, icon: string }> = [];
  
  fillerNav = Array.from({ length: 50 }, (_, i) => `Nav Item ${i + 1}`);

  fillerContent = Array.from({ length: 50 }, () =>
    `Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut
       labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco
       laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in
       voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat
       cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.`);

  private _mobileQueryListener: () => void;

  constructor(private httpService: Http, changeDetectorRef: ChangeDetectorRef, media: MediaMatcher) {
    this.mobileQuery = media.matchMedia('(max-width: 600px)');
    this._mobileQueryListener = () => changeDetectorRef.detectChanges();
    this.mobileQuery.addListener(this._mobileQueryListener);

    this.links.push(
      { text: 'Hero', path: '/', icon: "library_books" },
      { text: 'Bank Account', path: 'bankAccount', icon: "account_balance" },
      { text: 'Books', path: 'books', icon: "library_books" },
      { text: 'Countries', path: 'countries', icon: "question_answer" },
      { text: 'Customers', path: 'customers', icon: "contacts" },
      { text: 'Software', path: 'software', icon: "web" },
      { text: 'Register', path: '', icon: "person_add" },
      { text: 'Login', path: 'login', icon: "account_circle" }
    );

  }

  apiValues: string[] = [];
  ngOnInit() {
    //let dataService: DataService = new DataService(this.httpService);
    //dataService.returnValues().then((data) => {
    //  this.apiValues = data;
    //}).catch((error) => {
    //  console.log("An unknown error occured while returning values: " + error);
    //});
  }

    //shouldRun = [/(^|\.)plnkr\.co$/, /(^|\.)stackblitz\.io$/].some(h => h.test(window.location.host));

    shouldRun = true;
}
