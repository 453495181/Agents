import { Component, Injector } from '@angular/core';
import { env } from '../../env';
import { EditComponentBase } from '../../../util';
import { OutCashViewModel } from './model/out-cash-view-model';

/**
 * 提现详情页
 */
@Component({
    selector: 'out-cash-detail',
    templateUrl: !env.dev() ? './html/detail.component.html' : '/view/agents/out-cash/detail'
})
export class OutCashDetailComponent extends EditComponentBase<OutCashViewModel> {
    /**
     * 初始化提现详情页
     * @param injector 注入器
     */
    constructor(injector: Injector) {
        super(injector);
    }

    /**
     * 获取基地址
     */
    protected getBaseUrl() {
        return "out-cash";
    }
}