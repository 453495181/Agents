using System;
using System.Threading.Tasks;
using Util.Webs.Controllers;
using Microsoft.AspNetCore.Mvc;
using Agents.Service.Dtos.Sales;
using Agents.Service.Dtos.Sales.Requests;
using Agents.Service.Queries.Sales;
using Agents.Service.Abstractions.Sales;
using Util;
using Util.Webs.Properties;

namespace Agents.Apis.Sales {
    /// <summary>
    /// 订单控制器
    /// </summary>
    public class OrderController : QueryControllerBase<OrderDto, OrderQuery> {
        /// <summary>
        /// 初始化订单控制器
        /// </summary>
        /// <param name="service">订单服务</param>
        public OrderController(IOrderService service) : base(service) {
            OrderService = service;
        }

        /// <summary>
        /// 订单服务
        /// </summary>
        public IOrderService OrderService { get; }


        /// <summary>
        /// 分页查询
        /// </summary>
        [HttpGet]
        public override async Task<IActionResult> PagerQueryAsync(OrderQuery query) {
            PagerQueryBefore(query);
            var result = await OrderService.PagerQueryOrderAsync(query);
            return Success(ToPagerQueryResult(result));
        }

        /// <summary>
        /// 根据Id获取订单
        /// </summary>
        /// <param name="id">标识</param>
        [HttpGet("{id}")]
        public override async Task<IActionResult> GetAsync(string id) {
            var byIdAsync = await OrderService.GetOrderByIdAsync(id.ToGuid());
            return Success(byIdAsync);
        }

        /// <summary>
        /// 创建订单
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> CreateAsync([FromBody] OrderCreateRequest request) {
            if (request == null) {
                return Fail(WebResource.CreateRequestIsEmpty);
            }
            var id = await OrderService.CreateAsync(request);
            return Success(id);
        }

        /// <summary>
        /// 支付订单
        /// </summary>
        [HttpPut("Pay{id}")]
        public async Task<IActionResult> PayedAsync(string id) {
            if (id.IsEmpty() || id.ToGuid() == Guid.Empty)
                return Fail(WebResource.IdIsEmpty);
            await OrderService.PayAsync(id.ToGuid());
            return Success();
        }
    }
}