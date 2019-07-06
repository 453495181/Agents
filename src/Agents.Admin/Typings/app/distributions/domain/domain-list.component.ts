import { Component, Injector } from '@angular/core';
import { env } from '../../env';
import { TableQueryComponentBase } from '../../../util';
import { DomainQuery } from './model/domain-query';
import { DomainViewModel } from './model/domain-view-model';

/**
 * 域名列表页
 */
@Component({
    selector: 'domain-list',
    templateUrl: !env.dev() ? './html/index.component.html' : '/view/distributions/domain'
})
export class DomainListComponent extends TableQueryComponentBase<DomainViewModel, DomainQuery>  {
    /**
     * 初始化域名列表页
     * @param injector 注入器
     */
    constructor(injector: Injector) {
        super(injector);
    }
}