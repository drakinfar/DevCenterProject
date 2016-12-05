import { Component, OnInit, Input } from '@angular/core'
import { MilestoneService } from '../../services/milestone.service'
import { ActivatedRoute } from '@angular/router'

@Component({
	selector: 'milestone-list',
	template: require('./milestone.component.html'),
	providers: [MilestoneService]
})
export class MilestoneComponent implements OnInit {
	@Input() milestoneList = {};
	@Input() id = 0;

	constructor(private milestoneService: MilestoneService, private activatedRoute: ActivatedRoute) { }

	ngOnInit(): void {
		this.activatedRoute.params.subscribe(
			(param: any) => {
				this.id = param['id'];
			});

		if (this.id > 0) {
			this.milestoneService.getMilestoneList(this.id)
				.subscribe(item => {
					this.milestoneList = item;
				});
		}
	}
}
