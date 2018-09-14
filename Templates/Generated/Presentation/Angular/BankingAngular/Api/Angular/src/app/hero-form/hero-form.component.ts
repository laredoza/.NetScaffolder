import { Component } from '@angular/core';
import { Hero } from '../hero';
import { Http } from '@angular/http'
import { DataService } from "../../services/data.services";


@Component({
  selector: 'app-hero-form',
  templateUrl: './hero-form.component.html',
  styleUrls: ['./hero-form.component.css']
})
export class HeroFormComponent {

  model: Hero;

  constructor(private httpService: Http) {
    let dataService: DataService = new DataService(this.httpService);
    dataService.returnHero().then((data) => {
      this.model = data;
    }).catch((error) => {
      console.log("An unknown error occured while returning values: " + error);
    });
  }
  powers = ['Really Smart', 'Super Flexible',
    'Super Hot', 'Weather Changer'];

  submitted = false;

  onSubmit() { this.submitted = true; }

  newHero() {
    // https://angular.io/guide/forms
    this.model = new Hero(42, '', '');
  }
}
