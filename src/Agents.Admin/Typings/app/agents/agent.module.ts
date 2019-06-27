import { NgModule } from '@angular/core';
import { FrameworkModule } from '../framework.module';
import { AgentRoutingModule } from './agent-routing.module';
import { AgentListComponent } from './agent/agent-list.component';
import { AgentCreateComponent } from './agent/agent-create.component';
import { AgentEditComponent } from './agent/agent-edit.component';
import { AgentDetailComponent } from './agent/agent-detail.component';
import { OutCashListComponent } from './out-cash/out-cash-list.component';
import { OutCashCreateComponent } from './out-cash/out-cash-create.component';
import { OutCashEditComponent } from './out-cash/out-cash-edit.component';
import { OutCashDetailComponent } from './out-cash/out-cash-detail.component';

/**
 * agents模块
 */
@NgModule({
    declarations: [
        AgentListComponent,AgentCreateComponent,AgentEditComponent,AgentDetailComponent,
        OutCashListComponent,OutCashCreateComponent,OutCashEditComponent,OutCashDetailComponent,
    ],
    imports: [
        FrameworkModule,AgentRoutingModule
    ]
})
export class AgentModule {
}