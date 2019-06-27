import { Component, Injector } from '@angular/core';
import { env } from '../../env';
import { EditComponentBase } from '../../../util';
import { MemberViewModel } from './model/member-view-model';

/**
 * 会员详情页
 */
@Component({
    selector: 'member-detail',
    templateUrl: !env.dev() ? './html/detail.component.html' : '/view/members/member/detail'
})
export class MemberDetailComponent extends EditComponentBase<MemberViewModel> {
    /**
     * 初始化会员详情页
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