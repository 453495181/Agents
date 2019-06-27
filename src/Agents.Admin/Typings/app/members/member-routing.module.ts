import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

import { DownloadLogListComponent } from './download-log/download-log-list.component';
import { DownloadLogCreateComponent } from './download-log/download-log-create.component';
import { DownloadLogEditComponent } from './download-log/download-log-edit.component';
import { DownloadLogDetailComponent } from './download-log/download-log-detail.component';

import { MemberListComponent } from './member/member-list.component';
import { MemberCreateComponent } from './member/member-create.component';
import { MemberEditComponent } from './member/member-edit.component';
import { MemberDetailComponent } from './member/member-detail.component';

//路由配置
const routes: Routes = [
    {
        path: '',
        children: [
            {path: 'downloadLog', children: [
                { path: '', component: DownloadLogListComponent },
                { path: 'create', component: DownloadLogCreateComponent },
                { path: 'edit/:id', component: DownloadLogEditComponent },
                { path: 'detail/:id', component: DownloadLogDetailComponent }
            ]},
            {path: 'member', children: [
                { path: '', component: MemberListComponent },
                { path: 'create', component: MemberCreateComponent },
                { path: 'edit/:id', component: MemberEditComponent },
                { path: 'detail/:id', component: MemberDetailComponent }
            ]},
        ]
    }
];

/**
 * members路由模块
 */
@NgModule({
    imports: [RouterModule.forChild(routes)]
})
export class MemberRoutingModule { }