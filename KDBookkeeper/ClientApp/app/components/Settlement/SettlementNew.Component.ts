import { Component, OnInit, Input } from '@angular/core'
import { FormGroup, FormControl, Validators } from '@angular/forms'
import { ActivatedRoute } from '@angular/router'
import { SettlementService } from '../../services/settlement.service'
import { GameTypeService } from '../../services/gametype.service'
import { Router } from "@angular/router"


@Component({
	selector: 'settlement-new-form',
	template: require('./settlementnew.component.html')
})
export class SettlementNewComponent implements OnInit {
	gameTypes = [];

	settlementData = {
		name: '',
		death: 0,
		population: 0,
		gameTypeId: 0,
	}

	constructor(private settlementService: SettlementService, private gameTypeService: GameTypeService, private activatedRoute: ActivatedRoute, private router: Router) { }

	ngOnInit(): void {
		this.gameTypeService.getGameTypes().subscribe(gametype => {
			this.gameTypes = gametype;
		});
	}

	createNewSettlement(form: any): void {
		this.settlementData.name = form.name;
		this.settlementData.death = form.death;
		this.settlementData.population = form.population
		this.settlementData.gameTypeId = form.gametype
		debugger;
		this.settlementService.createSettlement(this.settlementData).subscribe(result => {
			if (result > 0) {
				this.router.navigate(['/settlement/view', result]);
			}
		});
	}
}

