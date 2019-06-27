import { Component, Injector } from '@angular/core';
import { env } from '../../env';
import { TableQueryComponentBase } from '../../../util';
import { SubAgentQuery } from './model/sub-agent-query';
import { SubAgentViewModel } from './model/sub-agent-view-model';

/**
 * 代理列表页
 */
@Component({
    selector: 'agent-list',
    templateUrl: !env.dev() ? './html/index.component.html' : '/view/agents/subagent'
})
export class SubAgentListComponent extends TableQueryComponentBase<SubAgentViewModel, SubAgentQuery>  {
    /**
     * 初始化代理列表页
     * @param injector 注入器
     */
    constructor(injector: Injector) {
        super(injector);
    }

    /**
    * 创建查询参数
    */
     createQuery(): SubAgentQuery {

        let result = new SubAgentQuery();
        result.level = 1;
        return result;
    }
}