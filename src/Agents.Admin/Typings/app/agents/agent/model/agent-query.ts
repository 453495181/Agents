import { QueryParameter } from '../../../../util';

/**
 * 代理查询参数
 */
export class AgentQuery extends QueryParameter {
    /**
     * 代理标识
     */
    agentId;
    /**
     * 编码
     */
    code;
    /**
     * 姓名
     */
    name;
    /**
     * 上级代理标识
     */
    parentId;
    /**
     * 代理路径
     */
    agentPath;
    /**
     * 支付宝帐号
     */
    alipayAccount;
    /**
     * 个人微信号
     */
    weChatAccount;
    /**
     * 邮箱
     */
    email;
    /**
     * 手机
     */
    mobile;
    /**
     * 开户银行
     */
    bank;
    /**
     * 开户名
     */
    bankUser;
    /**
     * 银行卡号
     */
    bandNumber;
    /**
     * 联系QQ
     */
    qq;
    /**
     * 启用
     */
    enabled;
    /**
     * 提现总额
     */
    cashOutTotal;
    /**
     * 备注
     */
    note;
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