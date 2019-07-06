using System.Threading.Tasks;
using Util.Webs.Controllers;
using Microsoft.AspNetCore.Mvc;
using Agents.Service.Dtos.Members;
using Agents.Service.Dtos.Members.Requests;
using Agents.Service.Queries.Members;
using Agents.Service.Abstractions.Members;
using Util;
using Util.Webs.Properties;

namespace Agents.Apis.Members {
    /// <summary>
    /// 会员控制器
    /// </summary>
    public class MemberController : QueryControllerBase<MemberDto, MemberQuery> {
        /// <summary>
        /// 初始化会员控制器
        /// </summary>
        /// <param name="service">会员服务</param>
        public MemberController(IMemberService service) : base(service) {
            MemberService = service;
        }

        /// <summary>
        /// 会员服务
        /// </summary>
        public IMemberService MemberService { get; }

        /// <summary>
        /// 分页查询
        /// </summary>
        [HttpGet]
        public override async Task<IActionResult> PagerQueryAsync(MemberQuery query) {
            PagerQueryBefore(query);
            var result = await MemberService.PagerQueryMemberAsync(query);
            return Success(ToPagerQueryResult(result));
        }

        /// <summary>
        /// 根据Id获取会员
        /// </summary>
        /// <param name="id">标识</param>
        [HttpGet("{id}")]
        public override async Task<IActionResult> GetAsync(string id) {
            var byIdAsync = await MemberService.GetMemberByIdAsync(id.ToGuid());
            return Success(byIdAsync);
            
        }

        /// <summary>
        /// 创建会员
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] MemberCreateRequest request) {
            if (request == null) {
                return Fail(WebResource.CreateRequestIsEmpty);
            }
            var id = await MemberService.CreateAsync(request);
            return Success(id);
        }

        /// <summary>
        /// 修改会员
        /// </summary>
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(string id, [FromBody] MemberUpdateRequest request) {
            if (request == null)
                return Fail(WebResource.UpdateRequestIsEmpty);
            if (id.IsEmpty() && request.MemberId.IsEmpty())
                return Fail(WebResource.IdIsEmpty);
            if (request.MemberId.IsEmpty())
                request.MemberId = id.ToGuid();
            await MemberService.UpdateAsync(request);
            MemberDto byIdAsync = await MemberService.GetByIdAsync(request.MemberId);
            return Success(byIdAsync);
        }

        /// <summary>
        /// 删除会员
        /// </summary>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(string id) {
            await MemberService.DeleteMember(id);
            return Success();
        }

        /// <summary>
        /// 批量删除会员
        /// </summary>
        [HttpPost("delete")]
        public async Task<IActionResult> BatchDeleteAsync([FromBody] string ids) {
            await MemberService.DeleteMember(ids);
            return Success();
        }
    }
}