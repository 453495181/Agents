import { Component, Injector } from '@angular/core';
import { env } from '../../env';
import { EditComponentBase } from '../../../util';
import { DomainViewModel } from './model/domain-view-model';

/**
 * 域名新增页
 */
@Component({
    selector: 'domain-edit',
    templateUrl: !env.dev() ? './html/create.component.html' : '/view/distributions/domain/create'
})
export class DomainCreateComponent extends EditComponentBase<DomainViewModel> {
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