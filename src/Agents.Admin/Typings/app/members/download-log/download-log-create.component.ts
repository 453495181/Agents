import { Component, Injector } from '@angular/core';
import { env } from '../../env';
import { EditComponentBase } from '../../../util';
import { DownloadLogViewModel } from './model/download-log-view-model';

/**
 * 下载记录新增页
 */
@Component({
    selector: 'download-log-edit',
    templateUrl: !env.dev() ? './html/create.component.html' : '/view/members/downloadLog/create'
})
export class DownloadLogCreateComponent extends EditComponentBase<DownloadLogViewModel> {
    /**
     * 初始化下载记录编辑页
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