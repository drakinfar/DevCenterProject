export class KDSettlement {
	constructor(public id: number, public name: string) { }
}

export interface SurvivorHuntData {
	huntYear: number;
	monsterId: number;
	monsterLevel: number;
	settlementId: number;
	survivors: Survivor[];
}

export interface Survivor {
	name: string;
	survived: boolean;
	survivorId: number;
}