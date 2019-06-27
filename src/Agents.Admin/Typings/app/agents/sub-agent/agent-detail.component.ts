import { Component, Injector } from '@angular/core';
import { env } from '../../env';
import { EditComponentBase } from '../../../util';
import { AgentViewModel } from './model/agent-view-model';

/**
 * 代理详情页
 */
@Component({
    selector: 'agent-detail',
    templateUrl: !env.dev() ? './html/detail.component.html' : '/view/agents/agent/detail'
})
export class AgentDetailComponent extends EditComponentBase<AgentViewModel> {
    /**
     * 初始化代理详情页
     * @param injector 注入器
     */
    constructor(injector: Injector) {
        super(injector);
    }

    /**
     * 获取基地址
     */
    protected getBaseUrl() {
        return "agent";
    }
}