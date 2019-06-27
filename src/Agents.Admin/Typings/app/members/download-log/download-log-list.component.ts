import { Component, Injector } from '@angular/core';
import { env } from '../../env';
import { TableQueryComponentBase } from '../../../util';
import { DownloadLogQuery } from './model/download-log-query';
import { DownloadLogViewModel } from './model/download-log-view-model';

/**
 * 下载记录列表页
 */
@Component({
    selector: 'download-log-list',
    templateUrl: !env.dev() ? './html/index.component.html' : '/view/members/downloadLog'
})
export class DownloadLogListComponent extends TableQueryComponentBase<DownloadLogViewModel, DownloadLogQuery>  {
    /**
     * 初始化下载记录列表页
     * @param injector 注入器
     */
    constructor(injector: Injector) {
        super(injector);
    }
}