import { Injectable } from '@angular/core';
import { Http, Headers } from '@angular/http';
import 'rxjs';

@Injectable()
export class SurvivorService {

	constructor(private http: Http) { }

	getAvailableSurvivors(Id) {
		return this.http.get(`/api/Survivor/GetAvailableSurvivors?Id=${Id}`)
			.map(result => result.json());
	}

}