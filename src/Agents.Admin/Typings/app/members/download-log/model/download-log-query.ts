import { QueryParameter } from '../../../../util';

/**
 * 下载记录查询参数
 */
export class DownloadLogQuery extends QueryParameter {
    /**
     * 下载记录标识
     */
    downloadLogId;
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
     * 起始创建时间
     */
    beginCreationTime;
    /**
     * 结束创建时间
     */
    endCreationTime;
    /**
     * 创建人
     */
    creatorId;
    /**
     * 起始最后修改时间
     */
    beginLastModificationTime;
    /**
     * 结束最后修改时间
     */
    endLastModificationTime;
    /**
     * 最后修改人
     */
    lastModifierId;
}