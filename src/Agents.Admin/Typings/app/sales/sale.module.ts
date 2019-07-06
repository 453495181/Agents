import { NgModule } from '@angular/core';
import { FrameworkModule } from '../framework.module';
import { SaleRoutingModule } from './sale-routing.module';
import { OrderListComponent } from './order/order-list.component';
import { OrderCreateComponent } from './order/order-create.component';
import { OrderEditComponent } from './order/order-edit.component';
import { OrderDetailComponent } from './order/order-detail.component';

import { OrderCommissionComponent } from './order/order-commission.component';

import { SubOrderListComponent } from './order/sub-order-list.component';

/**
 * sales模块
 */
@NgModule({
    declarations: [
        OrderListComponent, OrderCreateComponent, OrderEditComponent, OrderDetailComponent, SubOrderListComponent,
        OrderCommissionComponent
    ],
    imports: [
        FrameworkModule,SaleRoutingModule
    ]
})
export class SaleModule {
}