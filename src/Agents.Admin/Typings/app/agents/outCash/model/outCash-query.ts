import { QueryParameter } from '../../../../util';

/**
 * 提现查询参数
 */
export class OutCashQuery extends QueryParameter {
    /**
     * 账户标识
     */
    outCashId;
    /**
     * 代理标识
     */
    agentId;
    /**
     * 提现金额
     */
    money;
    /**
     * 备注
     */
    note;
    /**
     * 支付类型
     */
    payType;
    /**
     * 用户卡号
     */
    cardId;
    /**
     * 状态
     */
    state;
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