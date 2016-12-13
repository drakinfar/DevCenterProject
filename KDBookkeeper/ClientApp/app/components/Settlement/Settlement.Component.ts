import { Component, OnInit, Input } from '@angular/core'
import { SettlementService } from '../../services/settlement.service'
import { ActivatedRoute } from '@angular/router'

@Component({
	selector: 'settlement-item',
	template: require('./settlement.component.html'),
})
export class SettlementComponent implements OnInit {
	@Input() settlement = {};
	@Input() id = 0;

	constructor(private settlementService: SettlementService, private activatedRoute: ActivatedRoute) { }

	ngOnInit(): void {
		this.activatedRoute.params.subscribe(
			(param: any) => {
				this.id = param['id'];
			});

		if (this.id > 0) {
			this.settlementService.getSettlement(this.id)
				.subscribe(settlement => {
					this.settlement = settlement;
				});
		}
	}
}
