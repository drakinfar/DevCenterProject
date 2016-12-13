import { Component, OnInit, Input } from '@angular/core'
import { SettlementService } from '../../services/settlement.service'
import { ActivatedRoute } from '@angular/router'
import { FormGroup, FormControl, Validators } from '@angular/forms'
import { Router } from "@angular/router"

@Component({
	selector: 'settlement-wizard',
	template: require('./settlementphase.component.html'),
})
export class SettlementPhaseComponent implements OnInit {
	settlementList = [];
	@Input() id = 0;

	constructor(private settlementService: SettlementService, private activatedRoute: ActivatedRoute, private router: Router) { }

	ngOnInit(): void {

	}
}