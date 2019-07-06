import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { CommissionListComponent } from './commission/commission-list.component';
import { CommissionCreateComponent } from './commission/commission-create.component';
import { CommissionEditComponent } from './commission/commission-edit.component';
import { CommissionDetailComponent } from './commission/commission-detail.component';

import { DomainListComponent } from './domain/domain-list.component';
import { DomainCreateComponent } from './domain/domain-create.component';
import { DomainEditComponent } from './domain/domain-edit.component';
import { DomainDetailComponent } from './domain/domain-detail.component';

import { DomainTypeListComponent } from './domain-type/domain-type-list.component';
import { DomainTypeCreateComponent } from './domain-type/domain-type-create.component';
import { DomainTypeEditComponent } from './domain-type/domain-type-edit.component';
import { DomainTypeDetailComponent } from './domain-type/domain-type-detail.component';

//路由配置
const routes: Routes = [
    {
        path: '',
        children: [
            {path: 'commission', children: [
                { path: '', component: CommissionListComponent },
                { path: 'create', component: CommissionCreateComponent },
                { path: 'edit/:id', component: CommissionEditComponent },
                { path: 'detail/:id', component: CommissionDetailComponent }
            ]},
            {path: 'domain', children: [
                { path: '', component: DomainListComponent },
                { path: 'create', component: DomainCreateComponent },
                { path: 'edit/:id', component: DomainEditComponent },
                { path: 'detail/:id', component: DomainDetailComponent }
            ]},
            {path: 'domain-type', children: [
                { path: '', component: DomainTypeListComponent },
                { path: 'create', component: DomainTypeCreateComponent },
                { path: 'edit/:id', component: DomainTypeEditComponent },
                { path: 'detail/:id', component: DomainTypeDetailComponent }
            ]},
        ]
    }
];

/**
 * distributions路由模块
 */
@NgModule({
    imports: [RouterModule.forChild(routes)]
})
export class DistributionRoutingModule { }