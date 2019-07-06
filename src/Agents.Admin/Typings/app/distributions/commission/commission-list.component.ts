import { Component, Injector } from '@angular/core';
import { env } from '../../env';
import { TableQueryComponentBase } from '../../../util';
import { CommissionQuery } from './model/commission-query';
import { CommissionViewModel } from './model/commission-view-model';

/**
 * 佣金列表页
 */
@Component({
    selector: 'commission-list',
    templateUrl: !env.dev() ? './html/index.component.html' : '/view/distributions/commission'
})
export class CommissionListComponent extends TableQueryComponentBase<CommissionViewModel, CommissionQuery>  {
    /**
     * 初始化佣金列表页
     * @param injector 注入器
     */
    constructor(injector: Injector) {
        super(injector);
    }
}