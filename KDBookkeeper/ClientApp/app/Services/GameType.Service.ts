import { Injectable } from '@angular/core';
import { Http } from '@angular/http';
import 'rxjs';

@Injectable()
export class GameTypeService {

	constructor(private http: Http) { }

	getGameTypes() {
		return this.http.get(`/api/GameType/GetGameTypes`)
			.map(result =>
				result.json());
	}
}