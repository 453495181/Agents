import { QueryParameter } from '../../../../util';

/**
 * 订单查询参数
 */
export class OrderQuery extends QueryParameter {
    /**
     * 商品名称
     */
    goodsName;
    /**
     * 订单标识
     */
    orderId;
    /**
     * 会员标识
     */
    memberId;
    /**
     * 金额
     */
    money;
    /**
     * 类型
     */
    type;
    /**
     * 支付方式
     */
    payType;
    /**
     * 状态
     */
    state;
    /**
     * 起始下单时间
     */
    beginOrderTime;
    /**
     * 结束下单时间
     */
    endOrderTime;
    /**
     * 起始付款时间
     */
    beginPayTime;
    /**
     * 结束付款时间
     */
    endPayTime;
    /**
     * 扩展字段
     */
    extend;
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