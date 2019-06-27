import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { AgentListComponent } from './agent/agent-list.component';
import { AgentCreateComponent } from './agent/agent-create.component';
import { AgentEditComponent } from './agent/agent-edit.component';
import { AgentDetailComponent } from './agent/agent-detail.component';

import { SubAgentListComponent } from './sub-agent/sub-agent-list.component';
import { SubAgentCreateComponent } from './sub-agent/sub-agent-create.component';
import { SubAgentEditComponent } from './sub-agent/sub-agent-edit.component';
import { SubAgentDetailComponent } from './sub-agent/sub-agent-detail.component';


//路由配置
const routes: Routes = [
    {
        path: '',
        children: [
            {
                path: 'agent', children: [
                    { path: '', component: AgentListComponent },
                    { path: 'create', component: AgentCreateComponent },
                    { path: 'edit/:id', component: AgentEditComponent },
                    { path: 'detail/:id', component: AgentDetailComponent }
                ]
            },
            {
                path: 'subagent', children: [
                    { path: '', component: SubAgentListComponent },
                    { path: 'create', component: SubAgentCreateComponent },
                    { path: 'edit/:id', component: SubAgentEditComponent },
                    { path: 'detail/:id', component: SubAgentDetailComponent }
                ]
            }
        ]
    }
];

/**
 * agents路由模块
 */
@NgModule({
    imports: [RouterModule.forChild(routes)]
})
export class AgentRoutingModule { }