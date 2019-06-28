import { NgModule } from '@angular/core';
import { FrameworkModule } from '../framework.module';
import { MemberRoutingModule } from './member-routing.module';
import { DownloadLogListComponent } from './download-log/download-log-list.component';
import { DownloadLogCreateComponent } from './download-log/download-log-create.component';
import { DownloadLogEditComponent } from './download-log/download-log-edit.component';
import { DownloadLogDetailComponent } from './download-log/download-log-detail.component';
import { MemberListComponent } from './member/member-list.component';
import { MemberCreateComponent } from './member/member-create.component';
import { MemberEditComponent } from './member/member-edit.component';
import { MemberDetailComponent } from './member/member-detail.component';

import { SubMemberListComponent } from './member/sub-member-list.component';

/**
 * members模块
 */
@NgModule({
    declarations: [
        DownloadLogListComponent,DownloadLogCreateComponent,DownloadLogEditComponent,DownloadLogDetailComponent,
        MemberListComponent,MemberCreateComponent,MemberEditComponent,MemberDetailComponent,SubMemberListComponent
    ],
    imports: [
        FrameworkModule,MemberRoutingModule
    ]
})
export class MemberModule {
}