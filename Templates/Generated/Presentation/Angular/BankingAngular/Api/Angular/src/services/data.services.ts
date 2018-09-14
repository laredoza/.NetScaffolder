import { Http } from '@angular/http'
import { Hero } from '../app/hero';

export class DataService {
  httpService: Http;

  constructor(httpService: Http) {
    this.httpService = httpService;
  }

  apiValues: string[] = [];

  public returnValues(): Promise<string[]> {

    return new Promise((resolve, reject) => {
      this.httpService.get('/api/values').toPromise().then(values => {
        resolve(values.json() as string[]);
      }).catch((error) => {
        reject(error);
      });

    });
  }

  public returnHero(): Promise<Hero> {

    return new Promise((resolve, reject) => {
      //this.httpService.get('/api/values').toPromise().then(values => {
      //  resolve(values.json() as Hero);
      //}).catch((error) => {
      //  reject(error);
      //});
      resolve(new Hero(18, 'Dr IQ', 'Really Smart', 'Chuck Overstreet'));
    //);
    });
  }
}
