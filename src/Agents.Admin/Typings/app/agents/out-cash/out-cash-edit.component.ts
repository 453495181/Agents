import { Component, Injector } from '@angular/core';
import { env } from '../../env';
import { EditComponentBase } from '../../../util';
import { OutCashViewModel } from './model/out-cash-view-model';

/**
 * 提现编辑页
 */
@Component({
    selector: 'out-cash-edit',
    templateUrl: !env.dev() ? './html/edit.component.html' : '/view/agents/out-cash/edit'
})
export class OutCashEditComponent extends EditComponentBase<OutCashViewModel> {
    /**
     * 初始化提现编辑页
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