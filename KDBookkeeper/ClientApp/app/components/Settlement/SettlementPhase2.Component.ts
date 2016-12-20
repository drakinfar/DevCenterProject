import { Component, OnInit, Input } from '@angular/core'
import { PhaseService } from '../../services/phase.service'
import { ActivatedRoute } from '@angular/router'
import { FormGroup, FormControl, Validators, FormArray, FormBuilder } from '@angular/forms'
import { Router } from "@angular/router"
import { ILanternEvent } from './settlement.classes'

@Component({
	selector: 'settlement2-wizard',
	template: require('./settlementphase2.component.html'),
})
export class SettlementPhase2Component implements OnInit {
	id: number = 0;
	year: number = 0;
	event: ILanternEvent;

	constructor(
		private phaseService: PhaseService,
		private activatedRoute: ActivatedRoute,
		private router: Router) { }

	ngOnInit(): void {
		this.activatedRoute.params.subscribe(
			(param: any) => {
				this.id = param['id'];
				this.id = param['year'];
			});

		this.phaseService.generateSettlementEvent(this.year, this.id)
			.subscribe(lanternEvent => {
				this.event = lanternEvent;
			});
	}
}