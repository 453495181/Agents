using Util;
using Util.Maps;
using Agents.Distributions.Domain.Models;

namespace Agents.Service.Dtos.Distributions.Extensions {
    /// <summary>
    /// 佣金数据传输对象扩展
    /// </summary>
    public static class CommissionDtoExtension {
        /// <summary>
        /// 转换为佣金实体
        /// </summary>
        /// <param name="dto">佣金数据传输对象</param>
        public static Commission ToEntity(this CommissionDto dto) {
            if (dto == null)
                return new Commission();
            return dto.MapTo(new Commission(dto.Id.ToGuid()));
        }

        /// <summary>
        /// 转换为佣金数据传输对象
        /// </summary>
        /// <param name="entity">佣金实体</param>
        public static CommissionDto ToDto(this Commission entity) {
            if (entity == null)
                return new CommissionDto();
            var result = entity.MapTo<CommissionDto>();
            result.AgentName = entity.Agent.Name;
            result.OrderOutId = entity.Order.OrderOutId;
            return result;
        }

    }
}