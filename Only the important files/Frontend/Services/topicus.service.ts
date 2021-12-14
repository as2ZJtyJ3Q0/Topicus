import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
	providedIn: 'root'
})
export class TopicusService {

	private baseUrl = "https://localhost:44315/topicus"

	constructor(private http: HttpClient) {
	}
	getMedicine() {
		return this.http.get<any>(this.baseUrl + '/medicine');
	}

}