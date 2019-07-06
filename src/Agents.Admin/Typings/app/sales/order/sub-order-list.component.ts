import { Component, Injector } from '@angular/core';
import { env } from '../../env';
import { TableQueryComponentBase } from '../../../util';
import { OrderQuery } from './model/order-query';
import { OrderViewModel } from './model/order-view-model';

/**
 * 订单列表页
 */
@Component({
    selector: 'order-list',
    templateUrl: !env.dev() ? './html/index-agent.component.html' : '/view/sales/order/indexAgent'
})
export class SubOrderListComponent extends TableQueryComponentBase<OrderViewModel, OrderQuery>  {
    /**
     * 初始化订单列表页
     * @param injector 注入器
     */
    constructor(injector: Injector) {
        super(injector);
    }
}