import { ViewModel } from '../../../../util';

/**
 * 域名视图模型
 */
export class DomainViewModel extends ViewModel {
    /**
     * 域名分类标识
     */
    domainTypeId;
    /**
     * 域名
     */
    domainMember;
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