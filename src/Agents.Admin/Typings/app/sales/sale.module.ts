﻿import { NgModule } from '@angular/core';
import { FrameworkModule } from '../framework.module';
import { SaleRoutingModule } from './sale-routing.module';
import { OrderListComponent } from './order/order-list.component';
import { OrderCreateComponent } from './order/order-create.component';
import { OrderEditComponent } from './order/order-edit.component';
import { OrderDetailComponent } from './order/order-detail.component';

/**
 * sales模块
 */
@NgModule({
    declarations: [
        OrderListComponent,OrderCreateComponent,OrderEditComponent,OrderDetailComponent,
    ],
    imports: [
        FrameworkModule,SaleRoutingModule
    ]
})
export class SaleModule {
}