import { QueryParameter } from '../../../../util';

/**
 * 佣金查询参数
 */
export class CommissionQuery extends QueryParameter {
    /**
     * 佣金标识
     */
    commissionId;
    /**
     * 代理标识
     */
    agentId;
    /**
     * 订单标识
     */
    orderId;
    /**
     * 类型
     */
    type;
    /**
     * 金额
     */
    money;
    /**
     * 状态
     */
    state;
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