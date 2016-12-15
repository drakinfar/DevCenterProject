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