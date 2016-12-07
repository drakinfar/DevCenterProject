import { Component, OnInit, Input } from '@angular/core'
import { SettlementService } from '../../services/settlement.service'
import { ActivatedRoute } from '@angular/router'
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { KDSettlement } from './Settlement.Classes'
import { Router } from "angular2/router";

@Component({
	selector: 'settlement-list',
	template: require('./settlementlist.component.html'),
	providers: [SettlementService]
})
export class SettlementListComponent implements OnInit {
	@Input() settlementList = {};
	@Input() id = 0;

	settlement: KDSettlement = new KDSettlement(0, "");

	constructor(private settlementService: SettlementService, private activatedRoute: ActivatedRoute, private router: Router) { }

	selectSettlement(form: any) {
		this.settlement = new KDSettlement(form.Id, form.Name)
		//move to the new page
		this.router.navigate(['/settlement', form.Id]);
	}

	ngOnInit(): void {
		this.activatedRoute.params.subscribe(
			(param: any) => {
				this.id = param['id'];
			});

		this.settlementService.getSettlementNames()
			.subscribe(settlement => {
				var aArray = [];
				debugger;
				for (var i = 0; i < settlement.length; i++) {
					debugger;
					if (settlement[i].Id == this.id) {
						this.settlement = new KDSettlement(settlement[i].Id, settlement[i].Name);
					}

					aArray.push(new KDSettlement(settlement[i].Id, settlement[i].Name))
				}
				this.settlementList = aArray;
			});

	}
}

