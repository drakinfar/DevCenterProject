import { Component, OnInit, Input } from '@angular/core'
import { FormGroup, FormControl, Validators } from '@angular/forms'
import { ActivatedRoute } from '@angular/router'
import { SettlementService } from '../../services/settlement.service'


@Component({
	selector: 'settlement-new-form',
	template: require('./settlementnew.component.html'),
	providers: [SettlementService]
})
export class SettlementNewComponent implements OnInit {

	constructor(private settlementService: SettlementService, private activatedRoute: ActivatedRoute) { }

	ngOnInit(): void { }

	createNewSettlement(form: any): void {
		debugger;
		var i = form;
	}
}

