import { Component, Injector } from '@angular/core';
import { env } from '../../env';
import { EditComponentBase } from '../../../util';
import { OrderViewModel } from './model/order-view-model';

/**
 * 订单详情页
 */
@Component({
    selector: 'order-detail',
    templateUrl: !env.dev() ? './html/detail.component.html' : '/view/sales/order/detail'
})
export class OrderDetailComponent extends EditComponentBase<OrderViewModel> {
    /**
     * 初始化订单详情页
     * @param injector 注入器
     */
    constructor(injector: Injector) {
        super(injector);
    }

    /**
     * 获取基地址
     */
    protected getBaseUrl() {
        return "order";
    }
}