import { Injectable } from '@angular/core';
import { Http, Headers } from '@angular/http';
import { ISurvivorHuntData } from '../components/settlement/settlement.classes';
import 'rxjs';

@Injectable()
export class PhaseService {

	constructor(private http: Http) { }

	savePhase1(data)
	{
		var header = new Headers();
		header.append('Content-Type', 'application/json');
		debugger;
		return this.http.post('/api/Phase/SavePhase1',
			JSON.stringify(data),
			{
				headers: header
			})
			.map(res => res.json());

	}
}