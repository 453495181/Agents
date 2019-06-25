using Util;
using Util.Maps;
using Agents.Members.Domain.Models;

namespace Agents.Service.Dtos.Members.Extensions {
    /// <summary>
    /// 下载记录数据传输对象扩展
    /// </summary>
    public static class DownloadLogDtoExtension {
        /// <summary>
        /// 转换为下载记录实体
        /// </summary>
        /// <param name="dto">下载记录数据传输对象</param>
        public static DownloadLog ToEntity( this DownloadLogDto dto ) {
            if ( dto == null )
                return new DownloadLog();
            return dto.MapTo( new DownloadLog( dto.Id.ToGuid() ) );
        }
        
        /// <summary>
        /// 转换为下载记录数据传输对象
        /// </summary>
        /// <param name="entity">下载记录实体</param>
        public static DownloadLogDto ToDto(this DownloadLog entity) {
            if( entity == null )
                return new DownloadLogDto();
            return entity.MapTo<DownloadLogDto>();
        }

    }
}