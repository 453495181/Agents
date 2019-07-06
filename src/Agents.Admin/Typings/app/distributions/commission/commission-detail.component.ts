import { Component, Injector } from '@angular/core';
import { env } from '../../env';
import { EditComponentBase } from '../../../util';
import { CommissionViewModel } from './model/commission-view-model';

/**
 * 佣金详情页
 */
@Component({
    selector: 'commission-detail',
    templateUrl: !env.dev() ? './html/detail.component.html' : '/view/distributions/commission/detail'
})
export class CommissionDetailComponent extends EditComponentBase<CommissionViewModel> {
    /**
     * 初始化佣金详情页
     * @param injector 注入器
     */
    constructor(injector: Injector) {
        super(injector);
    }

    /**
     * 获取基地址
     */
    protected getBaseUrl() {
        return "commission";
    }
}