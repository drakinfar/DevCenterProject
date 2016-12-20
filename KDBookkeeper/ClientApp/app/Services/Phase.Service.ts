import { Injectable } from '@angular/core';
import { Http, Headers } from '@angular/http';
import { ISurvivorHuntData } from '../components/settlement/settlement.classes';
import 'rxjs';

@Injectable()
export class PhaseService {

	constructor(private http: Http) { }

	savePhase1(data) {
		var header = new Headers();
		header.append('Content-Type', 'application/json');
		return this.http.post('/api/Phase/SavePhase1',
			JSON.stringify(data),
			{
				headers: header
			})
			.map(res => res.json());
	}

	savePhase2(data) {
		var header = new Headers();
		header.append('Content-Type', 'application/json');
		return this.http.post('/api/Phase/SavePhase2',
			JSON.stringify(data),
			{
				headers: header
			})
			.map(res => res.json());
	}

	savePhase3(data) {
				var header = new Headers();
		header.append('Content-Type', 'application/json');
		return this.http.post('/api/Phase/SavePhase3',
			JSON.stringify(data),
			{
				headers: header
			})
			.map(res => res.json());
	}

	generateSettlementEvent(Year, Id) {
		return this.http.get(`/api/Phase/GenerateSettlementEvent?Year=${Year}&Id=${Id}`)
			.map(result =>
				result.json());
	}
}