import { NgModule } from '@angular/core';
import { FrameworkModule } from '../framework.module';
import { AgentRoutingModule } from './agent-routing.module';
import { AgentListComponent } from './agent/agent-list.component';
import { AgentEditComponent } from './agent/agent-edit.component';
import { AgentDetailComponent } from './agent/agent-detail.component';
import { OutCashListComponent } from './out-cash/outCash-list.component';
import { OutCashEditComponent } from './out-cash/outCash-edit.component';
import { OutCashDetailComponent } from './out-cash/outCash-detail.component';

/**
 * agents模块
 */
@NgModule({
    declarations: [
        AgentListComponent,AgentEditComponent,AgentDetailComponent,
        OutCashListComponent,OutCashEditComponent,OutCashDetailComponent,
    ],
    imports: [
        FrameworkModule,AgentRoutingModule
    ]
})
export class AgentModule {
}