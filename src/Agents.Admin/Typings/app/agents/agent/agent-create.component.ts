﻿import { Component, Injector } from '@angular/core';
import { env } from '../../env';
import { EditComponentBase } from '../../../util';
import { AgentViewModel } from './model/agent-view-model';

/**
 * 代理新增页
 */
@Component({
    selector: 'agent-edit',
    templateUrl: !env.dev() ? './html/create.component.html' : '/view/agents/agent/create'
})
export class AgentCreateComponent extends EditComponentBase<AgentViewModel> {
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
        return "agent";
    }
}