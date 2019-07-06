import { Component, Injector } from '@angular/core';
import { env } from '../../env';
import { EditComponentBase } from '../../../util';
import { CommissionViewModel } from './model/commission-view-model';

/**
 * 佣金编辑页
 */
@Component({
    selector: 'commission-edit',
    templateUrl: !env.dev() ? './html/edit.component.html' : '/view/distributions/commission/edit'
})
export class CommissionEditComponent extends EditComponentBase<CommissionViewModel> {
    /**
     * 初始化佣金编辑页
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