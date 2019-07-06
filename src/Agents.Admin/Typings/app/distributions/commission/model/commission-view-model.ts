import { ViewModel } from '../../../../util';

/**
 * 佣金视图模型
 */
export class CommissionViewModel extends ViewModel {
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