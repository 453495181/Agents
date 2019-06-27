import { Component, Injector } from '@angular/core';
import { env } from '../../env';
import { EditComponentBase } from '../../../util';
import { MemberViewModel } from './model/member-view-model';

/**
 * 会员编辑页
 */
@Component({
    selector: 'member-edit',
    templateUrl: !env.dev() ? './html/edit.component.html' : '/view/members/member/edit'
})
export class MemberEditComponent extends EditComponentBase<MemberViewModel> {
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