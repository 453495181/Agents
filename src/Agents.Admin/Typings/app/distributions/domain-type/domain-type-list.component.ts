import { Component, Injector } from '@angular/core';
import { env } from '../../env';
import { TableQueryComponentBase } from '../../../util';
import { DomainTypeQuery } from './model/domain-type-query';
import { DomainTypeViewModel } from './model/domain-type-view-model';

/**
 * 域名分类列表页
 */
@Component({
    selector: 'domain-type-list',
    templateUrl: !env.dev() ? './html/index.component.html' : '/view/distributions/domainType'
})
export class DomainTypeListComponent extends TableQueryComponentBase<DomainTypeViewModel, DomainTypeQuery>  {
    /**
     * 初始化域名分类列表页
     * @param injector 注入器
     */
    constructor(injector: Injector) {
        super(injector);
    }
}