import { Component, OnInit, Input } from '@angular/core'
import { SettlementService } from '../../services/settlement.service'
import { ActivatedRoute } from '@angular/router'
import { FormGroup, FormControl, Validators, FormArray, FormBuilder } from '@angular/forms'
import { Router } from "@angular/router"
import { SurvivorHuntData, Survivor} from './settlement.classes'

@Component({
	selector: 'settlement-wizard',
	template: require('./settlementphase1.component.html'),
})
export class SettlementPhase1Component implements OnInit {
	public phase1: FormGroup;
	public huntData: SurvivorHuntData;
	settlementList = [];
	 id = 0; //the settlement we are working with
	 year = 0; //the year we are working with.

	 constructor(
		 private settlementService: SettlementService,
		 private activatedRoute: ActivatedRoute,
		 private router: Router,
		 private formBuilder: FormBuilder) { }

	ngOnInit(): void {
		this.activatedRoute.params.subscribe(
			(param: any) => {
				this.id = param['id'];
				this.year = param['year'];
				this.huntData.huntYear = this.year;
				this.huntData.settlementId = this.id;
			});
	 }

	save(model: SurvivorHuntData) {
		// call API to save the data
		console.log(model);
	}
}