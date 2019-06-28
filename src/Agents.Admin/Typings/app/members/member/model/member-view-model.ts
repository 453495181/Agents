import { ViewModel } from '../../../../util';

/**
 * 会员视图模型
 */
export class MemberViewModel extends ViewModel {
    /**
     * 会员外部标识
     */
    memberOutId;
    /**
     * 上级代理
     */
    agentName;
    /**
     * 代理标识
     */
    agentId;
    /**
     * 代理路径
     */
    agentPath;
    /**
     * 姓名
     */
    name;
    /**
     * 手机
     */
    mobile;
    /**
     * IP
     */
    iPAddress;
    /**
     * 类型
     */
    type;
    /**
     * 会员到期时间
     */
    vipEndTime;
    /**
     * 设备系统
     */
    clientOS;
    /**
     * 设备硬件号
     */
    clientCode;
    /**
     * 消费总额
     */
    consumptionTotal;
    /**
     * 首次访问时间
     */
    firstTime;
    /**
     * 注册时间
     */
    registerTime;
    /**
     * 备注
     */
    note;
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