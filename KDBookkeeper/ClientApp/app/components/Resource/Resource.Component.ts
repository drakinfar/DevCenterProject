import { Component, OnInit, Input } from '@angular/core'
import { ResourceService } from '../../services/resource.service'
import { ActivatedRoute } from '@angular/router'

@Component({
	selector: 'resource-list',
	template: require('./Resource.component.html'),
	providers: [ResourceService]
})
export class ResourceComponent implements OnInit {
	@Input() resourceList = {};
	@Input() settlementId = 0;

	constructor(private resourceService: ResourceService, private activatedRoute: ActivatedRoute) { }

	ngOnInit(): void {
		this.activatedRoute.params.subscribe(
			(param: any) => {
				this.settlementId = param['id'];
			});

		if (this.settlementId > 0) {
			this.resourceService.getResourceList(this.settlementId)
				.subscribe(resourceList => {
					this.resourceList = resourceList;
				});
		}
	}
}