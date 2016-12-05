import { Injectable } from '@angular/core';
import { Http } from '@angular/http';
import 'rxjs';

@Injectable()
export class LocationService {

	constructor(private http: Http) { }

		getLocationList(Id) {
		return this.http.get('/api/Location/GetLocationList?Id=${Id}')
			.map(result =>
				result.json());
		}
}