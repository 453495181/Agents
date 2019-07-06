import { Component, Injector } from '@angular/core';
import { env } from '../../env';
import { TableQueryComponentBase } from '../../../util';

/**
 * 佣金列表页
 */
@Component({
    selector: 'commission-list',
    templateUrl: !env.dev() ? './html/order-commission.component.html' : '/view/sales/order/OrderCommission'
})
export class OrderCommissionComponent{
    /**
     * 初始化佣金列表页
     * @param injector 注入器
     */
    constructor(injector: Injector) {
        //super(injector);
    }
}