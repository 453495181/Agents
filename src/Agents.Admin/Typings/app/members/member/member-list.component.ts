import { Component, Injector } from '@angular/core';
import { env } from '../../env';
import { TableQueryComponentBase } from '../../../util';
import { MemberQuery } from './model/member-query';
import { MemberViewModel } from './model/member-view-model';

/**
 * 会员列表页
 */
@Component({
    selector: 'member-list',
    templateUrl: !env.dev() ? './html/index.component.html' : '/view/members/member'
})
export class MemberListComponent extends TableQueryComponentBase<MemberViewModel, MemberQuery>  {
    /**
     * 初始化会员列表页
     * @param injector 注入器
     */
    constructor(injector: Injector) {
        super(injector);
    }
}