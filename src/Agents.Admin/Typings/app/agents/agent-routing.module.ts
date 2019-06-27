import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { AgentListComponent } from './agent/agent-list.component';
import { AgentCreateComponent } from './agent/agent-create.component';
import { AgentEditComponent } from './agent/agent-edit.component';
import { AgentDetailComponent } from './agent/agent-detail.component';

//路由配置
const routes: Routes = [
    {
        path: '',
        children: [
            {path: 'agent', children: [
                { path: '', component: AgentListComponent },
                { path: 'create', component: AgentCreateComponent },
                { path: 'edit/:id', component: AgentEditComponent },
                { path: 'detail/:id', component: AgentDetailComponent }
            ]},
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