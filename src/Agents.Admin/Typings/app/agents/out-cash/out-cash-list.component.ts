﻿import { Component, Injector } from '@angular/core';
import { env } from '../../env';
import { TableQueryComponentBase } from '../../../util';
import { OutCashQuery } from './model/out-cash-query';
import { OutCashViewModel } from './model/out-cash-view-model';

/**
 * 提现列表页
 */
@Component({
    selector: 'out-cash-list',
    templateUrl: !env.dev() ? './html/index.component.html' : '/view/agents/outCash'
})
export class OutCashListComponent extends TableQueryComponentBase<OutCashViewModel, OutCashQuery>  {
    /**
     * 初始化提现列表页
     * @param injector 注入器
     */
    constructor(injector: Injector) {
        super(injector);
    }

    audit(button?, id?) {

        this.util.webapi.get<string>(`/api/outcash/audit`).param("id", id).handle({
            ok: result => {
                if (result === "ok") {
                    this.util.message.info("审核成功");
                }
            }
        });
    }

    refuse(button?, id?) {

        this.util.webapi.get<string>(`/api/outcash/refuse`).param("id", id).handle({
            ok: result => {
                if (result === "ok") {
                    this.util.message.info("拒绝成功");
                }
            }
        });
    }
}