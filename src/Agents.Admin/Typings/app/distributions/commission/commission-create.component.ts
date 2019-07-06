import { Component, Injector } from '@angular/core';
import { env } from '../../env';
import { EditComponentBase } from '../../../util';
import { CommissionViewModel } from './model/commission-view-model';

/**
 * 佣金新增页
 */
@Component({
    selector: 'commission-edit',
    templateUrl: !env.dev() ? './html/create.component.html' : '/view/distributions/commission/create'
})
export class CommissionCreateComponent extends EditComponentBase<CommissionViewModel> {
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