import { Component, Injector } from '@angular/core';
import { env } from '../../env';
import { EditComponentBase } from '../../../util';
import { OutCashViewModel } from './model/out-cash-view-model';

/**
 * 提现新增页
 */
@Component({
    selector: 'out-cash-edit',
    templateUrl: !env.dev() ? './html/create.component.html' : '/view/agents/outCash/create'
})
export class OutCashCreateComponent extends EditComponentBase<OutCashViewModel> {
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
        return "outcash";
    }


    loadById() {

        //代理和账号ID同号
        const id = "97F08B03-50D4-44E4-AD12-36A4D9EF4B36";
        this.util.webapi.get<number>(`/api/${this.getBaseUrl()}/getAbleMoney`).param("id",id).handle({
            ok: result => {
                this.model.ableOutMoney = result;
            }
        });
    }

}