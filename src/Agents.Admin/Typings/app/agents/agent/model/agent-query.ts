import { QueryParameter } from '../../../../util';

/**
 * 代理查询参数
 */
export class AgentQuery extends QueryParameter { 
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
    parentCode;
}