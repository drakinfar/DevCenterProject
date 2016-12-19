import { Component, OnInit, Input } from '@angular/core'
import { SettlementService } from '../../services/settlement.service'
import { SurvivorService } from '../../services/survivor.service'
import { PhaseService } from '../../services/phase.service'
import { ActivatedRoute } from '@angular/router'
import { FormGroup, FormControl, Validators, FormArray, FormBuilder } from '@angular/forms'
import { Router } from "@angular/router"
import { ISurvivorHuntData, ISurvivor, IMonster } from './settlement.classes'

@Component({
	selector: 'settlement2-wizard',
	template: require('./settlementphase2.component.html'),
})
export class SettlementPhase2Component implements OnInit {

	constructor(
		private settlementService: SettlementService,
		private survivorService: SurvivorService,
		private phaseService: PhaseService,
		private activatedRoute: ActivatedRoute,
		private router: Router) { }

	ngOnInit(): void {

	}
}