import { Injectable } from '@angular/core';
import { Http } from '@angular/http';
import 'rxjs';

@Injectable()
export class InnovationService {

	constructor(private http: Http) { }

	getInnovationList(Id) {
		return this.http.get(`/api/Innovation/GetInnovationList?Id=${Id}`)
			.map(result =>
				result.json());
	}
}