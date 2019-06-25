import { Component, Injector } from '@angular/core';
import { env } from '../../env';
import { EditComponentBase } from '../../../util';
import { OutCashViewModel } from './model/outCash-view-model';

/**
 * 提现编辑页
 */
@Component({
    selector: 'outCash-edit',
    templateUrl: !env.dev() ? './html/outCash-edit.component.html' : '/view/agents/outCash/edit'
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
        return "outCash";
    }
}