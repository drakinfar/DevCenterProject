import { Injectable } from '@angular/core';
import { Http } from '@angular/http';
import 'rxjs';

@Injectable()
export class MilestoneService {

	constructor(private http: Http) { }

	getMilestoneList(Id) {
		return this.http.get(`/api/Milestone/GetMilestoneList?Id=${Id}`)
			.map(result =>
				result.json());
		}
}