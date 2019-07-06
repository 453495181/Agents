import { Component, Injector } from '@angular/core';
import { env } from '../../env';
import { EditComponentBase } from '../../../util';
import { DomainTypeViewModel } from './model/domain-type-view-model';

/**
 * 域名分类编辑页
 */
@Component({
    selector: 'domain-type-edit',
    templateUrl: !env.dev() ? './html/edit.component.html' : '/view/distributions/domainType/edit'
})
export class DomainTypeEditComponent extends EditComponentBase<DomainTypeViewModel> {
    /**
     * 初始化域名分类编辑页
     * @param injector 注入器
     */
    constructor(injector: Injector) {
        super(injector);
    }

    /**
     * 获取基地址
     */
    protected getBaseUrl() {
        return "domain-type";
    }
}