import { NgModule } from '@angular/core';
import { FrameworkModule } from '../framework.module';
import { AgentRoutingModule } from './agent-routing.module';
import { AgentListComponent } from './agent/agent-list.component';
import { AgentCreateComponent } from './agent/agent-create.component';
import { AgentEditComponent } from './agent/agent-edit.component';
import { AgentDetailComponent } from './agent/agent-detail.component';

/**
 * agents模块
 */
@NgModule({
    declarations: [
        AgentListComponent,AgentCreateComponent,AgentEditComponent,AgentDetailComponent,
    ],
    imports: [
        FrameworkModule,AgentRoutingModule
    ]
})
export class AgentModule {
}