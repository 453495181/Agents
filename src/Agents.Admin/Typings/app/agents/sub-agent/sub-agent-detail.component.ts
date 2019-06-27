import { Component, Injector } from '@angular/core';
import { env } from '../../env';
import { EditComponentBase } from '../../../util';
import { SubAgentViewModel } from './model/sub-agent-view-model';

/**
 * 代理详情页
 */
@Component({
    selector: 'agent-detail',
    templateUrl: !env.dev() ? './html/detail.component.html' : '/view/agents/subagent/detail'
})
export class SubAgentDetailComponent extends EditComponentBase<SubAgentViewModel> {
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
        return "subagent";
    }
}