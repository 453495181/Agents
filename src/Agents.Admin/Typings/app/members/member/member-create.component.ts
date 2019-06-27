import { Component, Injector } from '@angular/core';
import { env } from '../../env';
import { EditComponentBase } from '../../../util';
import { MemberViewModel } from './model/member-view-model';

/**
 * 会员新增页
 */
@Component({
    selector: 'member-edit',
    templateUrl: !env.dev() ? './html/create.component.html' : '/view/members/member/create'
})
export class MemberCreateComponent extends EditComponentBase<MemberViewModel> {
    /**
     * 初始化会员编辑页
     * @param injector 注入器
     */
    constructor(injector: Injector) {
        super(injector);
    }

    /**
     * 获取基地址
     */
    protected getBaseUrl() {
        return "member";
    }
}