import { ViewModel } from '../../../../util';

/**
 * 下载记录视图模型
 */
export class DownloadLogViewModel extends ViewModel {
    /**
     * 代理标识
     */
    agentId;
    /**
     * IP
     */
    iPAddress;
    /**
     * 设备系统
     */
    clientOS;
    /**
     * 设备硬件号
     */
    clientCode;
    /**
     * 创建时间
     */
    creationTime;
    /**
     * 创建人
     */
    creatorId;
    /**
     * 最后修改时间
     */
    lastModificationTime;
    /**
     * 最后修改人
     */
    lastModifierId;
    /**
     * 版本号
     */
    version;
}