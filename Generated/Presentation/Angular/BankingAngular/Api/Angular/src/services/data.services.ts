import { Http } from '@angular/http'

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
}
