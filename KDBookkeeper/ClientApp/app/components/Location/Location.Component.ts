import { Component, OnInit, Input } from '@angular/core'
import { LocationService } from '../../services/location.service'
import { ActivatedRoute } from '@angular/router'

@Component({
	selector: 'location-list',
	template: require('./location.component.html'),
	providers: [LocationService]
})
export class LocationComponent implements OnInit {
	@Input() locationList = {};
	@Input() id = 0;

	constructor(private locationService: LocationService, private activatedRoute: ActivatedRoute) { }

	ngOnInit(): void {
		this.activatedRoute.params.subscribe(
			(param: any) => {
				this.id = param['id'];
			});

		if (this.id > 0) {
			this.locationService.getLocationList(this.id)
				.subscribe(item => {
					this.locationList = item;
				});
		}
	}
}
