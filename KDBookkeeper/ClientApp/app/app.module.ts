import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { UniversalModule } from 'angular2-universal';
import { AppComponent } from './components/app/app.component'
import { NavMenuComponent } from './components/navmenu/navmenu.component';
import { HomeComponent } from './components/home/home.component';
import { FetchDataComponent } from './components/fetchdata/fetchdata.component';
import { CounterComponent } from './components/counter/counter.component';
import { SettlementComponent } from './components/settlement/settlement.component';
import { InnovationComponent } from './components/innovation/innovation.component';
import { LocationComponent } from './components/location/location.component';
import { MilestoneComponent } from './components/milestone/milestone.component';
import { NemisisComponent } from './components/nemisis/nemisis.component';
import { PrincipleComponent } from './components/principle/principle.component';
import { QuarryComponent } from './components/quarry/quarry.component';
import { ResourceComponent } from './components/resource/resource.component';
import { SettlementListComponent } from './components/settlement/settlementList.component'
import { SettlementNewComponent } from './components/settlement/settlementNew.component'

@NgModule({
    bootstrap: [ AppComponent ],
    declarations: [
      AppComponent,
      NavMenuComponent,
      CounterComponent,
			FetchDataComponent,
			SettlementComponent,
			InnovationComponent,
			LocationComponent,
			MilestoneComponent,
			NemisisComponent,
			PrincipleComponent,
			QuarryComponent,
			ResourceComponent,
			SettlementListComponent,
			SettlementNewComponent,
      HomeComponent
    ],
    imports: [
        UniversalModule, // Must be first import. This automatically imports BrowserModule, HttpModule, and JsonpModule too.
				RouterModule.forRoot([
					{ path: '', redirectTo: 'home', pathMatch: 'full' },
          { path: 'home', component: HomeComponent },
          { path: 'counter', component: CounterComponent },
					{ path: 'fetch-data', component: FetchDataComponent },
					{
						path: 'settlement',
						children: [
							{ path: 'view/:id', component: SettlementComponent }, // url: settlement/view/#
							{ path: 'new', component: SettlementNewComponent } // url: settlement/new
						]
					},
					//{ path: 'settlement/:id', component: SettlementComponent },
					//{ path: 'settlement/new', component: SettlementNewComponent },
          { path: '**', redirectTo: 'home' }
				]),
			FormsModule
    ]
})
export class AppModule {
}
