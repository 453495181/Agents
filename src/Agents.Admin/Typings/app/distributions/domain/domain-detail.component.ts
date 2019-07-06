import { Component, Injector } from '@angular/core';
import { env } from '../../env';
import { EditComponentBase } from '../../../util';
import { DomainViewModel } from './model/domain-view-model';

/**
 * 域名详情页
 */
@Component({
    selector: 'domain-detail',
    templateUrl: !env.dev() ? './html/detail.component.html' : '/view/distributions/domain/detail'
})
export class DomainDetailComponent extends EditComponentBase<DomainViewModel> {
    /**
     * 初始化域名详情页
     * @param injector 注入器
     */
    constructor(injector: Injector) {
        super(injector);
    }

    /**
     * 获取基地址
     */
    protected getBaseUrl() {
        return "domain";
    }
}