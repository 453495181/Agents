import { Component, Injector } from '@angular/core';
import { env } from '../../env';
import { EditComponentBase } from '../../../util';
import { DomainViewModel } from './model/domain-view-model';

/**
 * 域名编辑页
 */
@Component({
    selector: 'domain-edit',
    templateUrl: !env.dev() ? './html/edit.component.html' : '/view/distributions/domain/edit'
})
export class DomainEditComponent extends EditComponentBase<DomainViewModel> {
    /**
     * 初始化域名编辑页
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