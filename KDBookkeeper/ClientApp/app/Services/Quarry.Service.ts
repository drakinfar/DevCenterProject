import { Injectable } from '@angular/core';
import { Http } from '@angular/http';
import 'rxjs';

@Injectable()
export class QuarryService {

	constructor(private http: Http) { }

	getQuarryList(Id) {
		return this.http.get(`/api/Quarry/GetQuarryList?Id=${Id}`)
			.map(result =>
				result.json());
		}
}