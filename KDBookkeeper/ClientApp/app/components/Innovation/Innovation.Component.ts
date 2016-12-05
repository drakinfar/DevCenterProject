import { Component, OnInit, Input } from '@angular/core'
import { InnovationService } from '../../services/innovation.service'
import { ActivatedRoute } from '@angular/router'

@Component({
	selector: 'innovation-list',
	template: require('./innovation.component.html'),
	providers: [InnovationService]
})
export class InnovationComponent implements OnInit {
	@Input() innovationList = {};
	@Input() id = 0;

	constructor(private innovationService: InnovationService, private activatedRoute: ActivatedRoute) { }

	ngOnInit(): void {
		this.activatedRoute.params.subscribe(
			(param: any) => {
				this.id = param['id'];
			});

		if (this.id > 0) {
			this.innovationService.getInnovationList(this.id)
				.subscribe(item => {
					this.innovationList = item;
				});
		}
	}
}
