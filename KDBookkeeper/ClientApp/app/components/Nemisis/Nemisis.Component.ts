﻿import { Component, OnInit, Input } from '@angular/core'
import { NemisisService } from '../../services/nemisis.service'
import { ActivatedRoute } from '@angular/router'

@Component({
	selector: 'nemisis-list',
	template: require('./nemisis.component.html'),
})
export class NemisisComponent implements OnInit {
	@Input() nemisisList = {};
	@Input() id = 0;

	constructor(private nemisistService: NemisisService, private activatedRoute: ActivatedRoute) { }

	ngOnInit(): void {
		this.activatedRoute.params.subscribe(
			(param: any) => {
				this.id = param['id'];
			});

		if (this.id > 0) {
			this.nemisistService.getNemisisList(this.id)
				.subscribe(item => {
					this.nemisisList = item;
				});
		}
	}
}
