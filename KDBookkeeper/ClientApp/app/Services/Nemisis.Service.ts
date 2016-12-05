import { Injectable } from '@angular/core';
import { Http } from '@angular/http';
import 'rxjs';

@Injectable()
export class NemisisService {

	constructor(private http: Http) { }

	getNemisisList(Id) {
		return this.http.get('/api/Nemisis/GetNemisisList?Id=${Id}')
			.map(result =>
				result.json());
		}
}