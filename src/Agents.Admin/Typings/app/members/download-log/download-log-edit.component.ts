import { Component, Injector } from '@angular/core';
import { env } from '../../env';
import { EditComponentBase } from '../../../util';
import { DownloadLogViewModel } from './model/download-log-view-model';

/**
 * 下载记录编辑页
 */
@Component({
    selector: 'download-log-edit',
    templateUrl: !env.dev() ? './html/edit.component.html' : '/view/members/downloadLog/edit'
})
export class DownloadLogEditComponent extends EditComponentBase<DownloadLogViewModel> {
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