import { Component, Injector } from '@angular/core';
import { env } from '../../env';
import { EditComponentBase } from '../../../util';
import { DownloadLogViewModel } from './model/download-log-view-model';

/**
 * 下载记录详情页
 */
@Component({
    selector: 'download-log-detail',
    templateUrl: !env.dev() ? './html/detail.component.html' : '/view/members/downloadLog/detail'
})
export class DownloadLogDetailComponent extends EditComponentBase<DownloadLogViewModel> {
    /**
     * 初始化下载记录详情页
     * @param injector 注入器
     */
    constructor(injector: Injector) {
        super(injector);
    }

    /**
     * 获取基地址
     */
    protected getBaseUrl() {
        return "download-log";
    }
}