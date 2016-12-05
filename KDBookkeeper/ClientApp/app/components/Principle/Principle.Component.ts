import { Component, OnInit, Input } from '@angular/core'
import { PrincipleService } from '../../services/principle.service'
import { ActivatedRoute } from '@angular/router'

@Component({
	selector: 'principle-list',
	template: require('./principle.component.html'),
	providers: [PrincipleService]
})
export class PrincipleComponent implements OnInit {
	@Input() principleList = {};
	@Input() id = 0;

	constructor(private principleService: PrincipleService, private activatedRoute: ActivatedRoute) { }

	ngOnInit(): void {
		this.activatedRoute.params.subscribe(
			(param: any) => {
				this.id = param['id'];
			});

		if (this.id > 0) {
			this.principleService.getPrincipleList(this.id)
				.subscribe(principle => {
					this.principleList = principle;
				});
		}
	}
}
