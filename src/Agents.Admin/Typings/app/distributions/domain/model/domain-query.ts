import { QueryParameter } from '../../../../util';

/**
 * 域名查询参数
 */
export class DomainQuery extends QueryParameter {
    /**
     * 域名标识
     */
    domainId;
    /**
     * 域名分类标识
     */
    domainTypeId;
    /**
     * 域名
     */
    domainMember;
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