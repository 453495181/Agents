import { ViewModel } from '../../../../util';

/**
 * 提现视图模型
 */
export class OutCashViewModel extends ViewModel {
    /**
     * 代理标识
     */
    agentId;
    /**
     * 提现金额
     */
    money;

    /**
    * 可提现金额
    */
   ableOutMoney;
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