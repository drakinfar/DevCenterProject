import { Component, OnInit, Input } from '@angular/core'
import { SettlementService } from '../../services/settlement.service'
import { SurvivorService } from '../../services/survivor.service'
import { ActivatedRoute } from '@angular/router'
import { FormGroup, FormControl, Validators, FormArray, FormBuilder } from '@angular/forms'
import { Router } from "@angular/router"
import { ISurvivorHuntData, ISurvivor} from './settlement.classes'

@Component({
	selector: 'settlement-wizard',
	template: require('./settlementphase1.component.html'),
})
export class SettlementPhase1Component implements OnInit {
	public phase1: FormGroup;
	public huntData: ISurvivorHuntData = {
		huntYear: 0,
		monsterId: -1,
		monsterLevel: -1,
		settlementId: -1,
		survivors: [],
	};

	selSurvivor: ISurvivor;
	selSurvived: boolean = true;
	survivorList = [];
	 id = 0; //the settlement we are working with
	 year = 0; //the year we are working with.

	 constructor(
		private survivorService: SurvivorService,
		private activatedRoute: ActivatedRoute,
		private router: Router) { }

	 ngOnInit(): void {

		this.activatedRoute.params.subscribe(
			(param: any) => {
				this.id = param['id'];
				this.year = param['year'];
				this.huntData.huntYear = this.year;
				this.huntData.settlementId = this.id;
			});


		if (this.id > 0) {
			this.survivorService.getAvailableSurvivors(this.id)
				.subscribe(survivors => {
					for (var i = 0; i < survivors.length; i++) {
						this.survivorList.push(survivors[i]);
					}
				});
		}
	 }

	save(model: ISurvivorHuntData) {
		// call API to save the data
		console.log(model);
	}

	removeSurvivor(id: number) {
		if (id > -1) {
			this.huntData.survivors.splice(id, 1);
		}
	}

	addExistingSurvivor(survived: any) {
		if (this.selectedSurvivor != null) {
			this.selectedSurvivor.survived = survived;
			this.huntData.survivors.push(this.selectedSurvivor);
		}
	}

	get selectedSurvivor() {
		return this.selSurvivor;
	}

	set selectedSurvivor(value) {
		this.selSurvivor = value;
	}
}