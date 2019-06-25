import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AgentListComponent } from './agent/agent-list.component';
import { AgentEditComponent } from './agent/agent-edit.component';
import { AgentDetailComponent } from './agent/agent-detail.component';
import { OutCashListComponent } from './out-cash/outCash-list.component';
import { OutCashEditComponent } from './out-cash/outCash-edit.component';
import { OutCashDetailComponent } from './out-cash/outCash-detail.component';

//路由配置
const routes: Routes = [
    {
        path: '',
        children: [
            {path: 'agent', children: [
                { path: '', component: AgentListComponent },
                { path: 'create', component: AgentEditComponent },
                { path: 'edit/:id', component: AgentEditComponent },
                { path: 'detail/:id', component: AgentDetailComponent }
            ]},
            {path: 'out-cash', children: [
                { path: '', component: OutCashListComponent },
                { path: 'create', component: OutCashEditComponent },
                { path: 'edit/:id', component: OutCashEditComponent },
                { path: 'detail/:id', component: OutCashDetailComponent }
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