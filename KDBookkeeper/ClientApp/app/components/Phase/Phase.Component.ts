import { Component, OnInit, Input } from '@angular/core'
import { ActivatedRoute } from '@angular/router'
import { FormGroup, FormControl, Validators, FormArray, FormBuilder } from '@angular/forms'
import { Router } from "@angular/router"

@Component({
	selector: 'settlement-phase',
	template: require('./phase.component.html'),
})
export class PhaseComponent implements OnInit {

	phase: number = 0;
	year: number = 0;
	id: number = 0;

	constructor(
		private activatedRoute: ActivatedRoute,
		private router: Router) { }

	ngOnInit(): void {
		this.activatedRoute.params.subscribe(
			(param: any) => {
				this.phase = param['phase'];
				this.id = param['phase'];
				this.year = param['year'];
			});
	}
}