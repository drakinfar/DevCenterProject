import { Component, OnInit, Input } from '@angular/core'
import { QuarryService } from '../../services/quarry.service'
import { ActivatedRoute } from '@angular/router'

@Component({
	selector: 'quarry-list',
	template: require('./quarry.component.html'),
})
export class QuarryComponent implements OnInit {
	@Input() quarryList = {};
	@Input() id = 0;

	constructor(private qarryService: QuarryService, private activatedRoute: ActivatedRoute) { }

	ngOnInit(): void {
		this.activatedRoute.params.subscribe(
			(param: any) => {
				this.id = param['id'];
			});

		if (this.id > 0) {
			this.qarryService.getQuarryList(this.id)
				.subscribe(quarry => {
					this.quarryList = quarry;
				});
		}
	}
}

