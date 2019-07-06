import { ViewModel } from '../../../../util';

/**
 * 订单视图模型
 */
export class OrderViewModel extends ViewModel {
    /**
     * 商品名称
     */
    goodsName;
    /**
     * 会员标识
     */
    memberId;
    /**
     * 订单外部标识
     */
    orderOutId;
    /**
    * 会员名称
    */
    memberName;
    /**
     * 代理名称
     */
    memberAgentName;
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
     * 下单时间
     */
    orderTime;
    /**
     * 付款时间
     */
    payTime;
    /**
     * 扩展字段
     */
    extend;
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