import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { OrderListComponent } from './order/order-list.component';
import { OrderCreateComponent } from './order/order-create.component';
import { OrderEditComponent } from './order/order-edit.component';
import { OrderDetailComponent } from './order/order-detail.component';

import { SubOrderListComponent } from './order/sub-order-list.component';

//路由配置
const routes: Routes = [
    {
        path: '',
        children: [
            {path: 'order', children: [
                { path: '', component: OrderListComponent },
                { path: 'create', component: OrderCreateComponent },
                { path: 'edit/:id', component: OrderEditComponent },
                { path: 'detail/:id', component: OrderDetailComponent },
                { path: 'suborder', component: SubOrderListComponent },
            ]},
        ]
    }
];

/**
 * sales路由模块
 */
@NgModule({
    imports: [RouterModule.forChild(routes)]
})
export class SaleRoutingModule { }