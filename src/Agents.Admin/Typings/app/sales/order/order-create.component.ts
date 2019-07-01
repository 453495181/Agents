import { Component, Injector } from '@angular/core';
import { env } from '../../env';
import { EditComponentBase } from '../../../util';
import { OrderViewModel } from './model/order-view-model';

/**
 * 订单新增页
 */
@Component({
    selector: 'order-edit',
    templateUrl: !env.dev() ? './html/create.component.html' : '/view/sales/order/create'
})
export class OrderCreateComponent extends EditComponentBase<OrderViewModel> {
    /**
     * 初始化订单编辑页
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