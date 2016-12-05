import { Injectable } from '@angular/core';
import { Http } from '@angular/http';
import 'rxjs';

@Injectable()
export class ResourceService {

	constructor(private http: Http) { }

	getResourceList(Id) {
		return this.http.get('/api/Resource/GetResourceList?Id=${Id}')
			.map(result =>
				result.json());
		}
}