import { Injectable } from '@angular/core';
import { Http } from '@angular/http';
import 'rxjs';

@Injectable()
export class SettlementService {

	constructor(private http: Http) { }

	getSettlementNames() {
		return this.http.get('/api/Settlement/GetSettlementNames')
			.map(result => result.json());
	}

	getSettlement(Id) {
		return this.http.get(`/api/Settlement/GetSettlement?Id=${Id}`)
			.map(result =>		
				result.json());
	}

	//getArchiveList() {
	//	return this.http.get(`/api/Article/GetArchiveList`)
	//		.map(result => result.json());
	//}

	//getArchivesByMonth(id) {
	//	return this.http.get(`/api/Article/GetArchivesByMonth?start=${id}`)
	//		.map(result => result.json());
	//}
}