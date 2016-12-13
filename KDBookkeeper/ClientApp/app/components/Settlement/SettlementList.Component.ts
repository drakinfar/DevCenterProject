import { Component, OnInit, Input } from '@angular/core'
import { SettlementService } from '../../services/settlement.service'
import { ActivatedRoute } from '@angular/router'
import { FormGroup, FormControl, Validators } from '@angular/forms'
import { KDSettlement } from './Settlement.Classes'
import { Router } from "@angular/router"

@Component({
	selector: 'settlement-list',
	template: require('./settlementlist.component.html'),
})
export class SettlementListComponent implements OnInit {
	settlementList = [];
	@Input() id = 0;

	settlement: KDSettlement = new KDSettlement(0, "");

	constructor(private settlementService: SettlementService, private activatedRoute: ActivatedRoute, private router: Router) { }

	selectSettlement(form: any) {
		this.settlement = new KDSettlement(form.value, "")
		//move to the new page
		this.router.navigate(['/settlement/view', form.value]);
	}

	ngOnInit(): void {
		this.activatedRoute.params.subscribe(
			(param: any) => {
				this.id = param['id'];
			});

		this.settlementService.getSettlementNames()
			.subscribe(settlement => {
				for (var i = 0; i < settlement.length; i++) {
					if (settlement[i].Id == this.id) { //set the selected item
						this.settlement = new KDSettlement(settlement[i].id, settlement[i].name);
					}

					this.settlementList.push(new KDSettlement(settlement[i].id, settlement[i].name))
				}
			});

	}
}

