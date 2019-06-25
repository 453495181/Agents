import { Component, Injector } from '@angular/core';
import { env } from '../../env';
import { TableQueryComponentBase } from '../../../util';
import { OutCashQuery } from './model/outCash-query';
import { OutCashViewModel } from './model/outCash-view-model';

/**
 * 提现列表页
 */
@Component({
    selector: 'outCash-list',
    templateUrl: !env.dev() ? './html/outCash-index.component.html' : '/view/agents/outCash'
})
export class OutCashListComponent extends TableQueryComponentBase<OutCashViewModel, OutCashQuery>  {
    /**
     * 初始化提现列表页
     * @param injector 注入器
     */
    constructor(injector: Injector) {
        super(injector);
    }
}