import { Component, Injector } from '@angular/core';
import { env } from '../../env';
import { EditComponentBase } from '../../../util';
import { SubAgentViewModel } from './model/sub-agent-view-model';

/**
 * 代理编辑页
 */
@Component({
    selector: 'agent-edit',
    templateUrl: !env.dev() ? './html/mine.component.html' : '/view/agents/subagent/mine'
})
export class SubAgentMineComponent extends EditComponentBase<SubAgentViewModel> {
    /**
     * 初始化代理编辑页
     * @param injector 注入器
     */
    constructor(injector: Injector) {
        super(injector);
    }

    /**
     * 获取基地址
     */
    protected getBaseUrl() {
        return "subagent";
    }


    loadById() {

        this.util.webapi.get<SubAgentViewModel>(`/api/${this.getBaseUrl()}/mine`).handle({
            ok: result => {
                this.model = result;
            }
        });
    }


}