import { Component, Injector } from '@angular/core';
import { env } from '../../env';
import { TableQueryComponentBase } from '../../../util';
import { AgentQuery } from './model/agent-query';
import { AgentViewModel } from './model/agent-view-model';

/**
 * 代理列表页
 */
@Component({
    selector: 'agent-list',
    templateUrl: !env.dev() ? './html/list.component.html' : '/view/agents/agent'
})
export class AgentListComponent extends TableQueryComponentBase<AgentViewModel, AgentQuery>  {
    /**
     * 初始化代理列表页
     * @param injector 注入器
     */
    constructor(injector: Injector) {
        super(injector);
    }
}