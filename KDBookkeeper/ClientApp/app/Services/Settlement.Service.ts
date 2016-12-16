import { Injectable } from '@angular/core';
import { Http, Headers } from '@angular/http';
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

	getSettlementQuarry(Id) {
		return this.http.get(`/api/Settlement/GetSettlementQuarry?Id=${Id}`)
			.map(result => result.json());
	}

	createSettlement(settlementData) {
		var header = new Headers();
		header.append('Content-Type', 'application/json');

		return this.http.post('/api/Settlement/CreateSettlement',
			JSON.stringify(settlementData),
			{
				headers: header
			})
			.map(res => res.json());
	}

}