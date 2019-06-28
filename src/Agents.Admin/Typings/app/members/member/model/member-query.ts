import { QueryParameter } from '../../../../util';

/**
 * 会员查询参数
 */
export class MemberQuery extends QueryParameter {
    /**
     * 会员标识
     */
    memberId;
    /**
     * 会员外部标识
     */
    memberOutId;
    /**
     * 代理标识
     */
    agentId;
    /**
     * 代理编号
     */
    agentCode;
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
     * 起始会员到期时间
     */
    beginVipEndTime;
    /**
     * 结束会员到期时间
     */
    endVipEndTime;
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
     * 起始首次访问时间
     */
    beginFirstTime;
    /**
     * 结束首次访问时间
     */
    endFirstTime;
    /**
     * 起始注册时间
     */
    beginRegisterTime;
    /**
     * 结束注册时间
     */
    endRegisterTime;
    /**
     * 备注
     */
    note;
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