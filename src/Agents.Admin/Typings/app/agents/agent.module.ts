import { NgModule } from '@angular/core';
import { FrameworkModule } from '../framework.module';
import { AgentRoutingModule } from './agent-routing.module';
import { AgentListComponent } from './agent/agent-list.component';
import { AgentCreateComponent } from './agent/agent-create.component';
import { AgentEditComponent } from './agent/agent-edit.component';
import { AgentDetailComponent } from './agent/agent-detail.component';

import { SubAgentListComponent } from './sub-agent/sub-agent-list.component';
import { SubAgentCreateComponent } from './sub-agent/sub-agent-create.component';
import { SubAgentEditComponent } from './sub-agent/sub-agent-edit.component';
import { SubAgentDetailComponent } from './sub-agent/sub-agent-detail.component';
import { SubAgentMineComponent } from './sub-agent/sub-agent-mine.component';

import { OutCashListComponent } from './out-cash/out-cash-list.component';
import { OutCashCreateComponent } from './out-cash/out-cash-create.component';
import { OutCashEditComponent } from './out-cash/out-cash-edit.component';
import { OutCashDetailComponent } from './out-cash/out-cash-detail.component';

/**
 * agents模块
 */
@NgModule({
    declarations: [
        AgentListComponent, AgentCreateComponent, AgentEditComponent, AgentDetailComponent,
        SubAgentListComponent, SubAgentCreateComponent, SubAgentEditComponent, SubAgentDetailComponent, SubAgentMineComponent,
        OutCashListComponent, OutCashCreateComponent, OutCashEditComponent, OutCashDetailComponent
    ],
    imports: [
        FrameworkModule,AgentRoutingModule
    ]
})
export class AgentModule {
}