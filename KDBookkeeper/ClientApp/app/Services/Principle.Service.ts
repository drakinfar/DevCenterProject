import { Injectable } from '@angular/core';
import { Http } from '@angular/http';
import 'rxjs';

@Injectable()
export class PrincipleService {

	constructor(private http: Http) { }

	getPrincipleList(Id) {
		return this.http.get('/api/Principle/GetPrincipleList?Id=${Id}')
			.map(result =>
				result.json());
		}
}