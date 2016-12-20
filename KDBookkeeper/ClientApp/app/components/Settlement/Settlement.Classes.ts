export class KDSettlement {
	constructor(public id: number, public name: string) { }
}

export interface ISurvivorHuntData {
	huntYear: number;
	monsterId: number;
	monsterLevel: number;
	settlementId: number;
	survivors: ISurvivor[];
}

export interface ISurvivor {
	name: string;
	survived: boolean;
	survivorId: number;
}

export interface IMonster {
	name: string;
	monsterId: number;
	level: number;
}

export interface ILanternEvent {
	lanternEventId: number;
	name: string;
	description: string;
	eventConsequences: IEventConsequence[];
	eventCharts: IEventChart[];
}

export interface IEventConsequence {
	eventConsequenceId: number;
	ConsequenceType: number;
	ConsequenceObjectId: number;
	ConsequenceObjectType: number;
}

export interface IEventChart {
	eventChartId: number;
	dieRoll: string;
	chartTable: string;
}