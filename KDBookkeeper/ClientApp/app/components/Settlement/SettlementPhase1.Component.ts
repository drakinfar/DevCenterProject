import { Component, OnInit, Input } from '@angular/core'
import { SettlementService } from '../../services/settlement.service'
import { SurvivorService } from '../../services/survivor.service'
import { PhaseService } from '../../services/phase.service'
import { ActivatedRoute } from '@angular/router'
import { FormGroup, FormControl, Validators, FormArray, FormBuilder } from '@angular/forms'
import { Router } from "@angular/router"
import { ISurvivorHuntData, ISurvivor, IMonster } from './settlement.classes'

@Component({
	selector: 'settlement-wizard',
	template: require('./settlementphase1.component.html'),
})
export class SettlementPhase1Component implements OnInit {
	public huntData: ISurvivorHuntData = {
		huntYear: 0,
		monsterId: -1,
		monsterLevel: -1,
		settlementId: -1,
		survivors: []
	};

	public selMonster: IMonster = {
		name: "",
		monsterId: -1,
		level: -1
	};

	selSurvivor: ISurvivor;
	selSurvived: boolean = true;
	survivorList = [];
	monsterList = [];
	 id = 0; //the settlement we are working with
	 year = 0; //the year we are working with.

	//TODO: Validate input and warn if there is no creature.
	//todo: look into recording the gained resources from the hunt


	 constructor(
		private settlementService: SettlementService,
		private survivorService: SurvivorService,
		private phaseService: PhaseService,
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

			this.settlementService.getSettlementQuarry(this.id)
				.subscribe(quarry => {
					for (var i = 0; i < quarry.length; i++) {
						this.monsterList.push(quarry[i]);
					}
				});
		}
	 }

	save() {	
		this.huntData.monsterLevel = this.selectedMonster.level;
		this.huntData.monsterId = this.selectedMonster.monsterId;
		this.phaseService.savePhase1(this.huntData).subscribe(result => {
			debugger;
			if (result > 0) {
				//this.router.navigate(['/settlement/view', result]);
			}
		});;
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

	addNewSurvivor(name: string, survived: any) {
		var model = {
			survivorId: -1,
			name: name,
			survived: survived
		}
		this.huntData.survivors.push(model);
	}

	removeMonster() {
		this.selMonster.level = -1;
		this.selMonster.name = "";
		this.selMonster.monsterId = -1;
	}

	addMonster(level: any)
	{
		this.selMonster.level = level;
	}

	get selectedSurvivor() {
		return this.selSurvivor;
	}

	set selectedSurvivor(value) {
		this.selSurvivor = value;
	}

	get selectedMonster() {
		return this.selMonster;
	}

	set selectedMonster(value) {
		this.selMonster = value;
	}


}