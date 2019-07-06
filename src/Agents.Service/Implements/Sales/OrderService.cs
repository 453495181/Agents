using System;
using System.Linq;
using System.Threading.Tasks;
using Agents.Agents.Domain.Models;
using Agents.Agents.Domain.Services.Abstractions;
using Util;
using Util.Maps;
using Util.Domains.Repositories;
using Util.Datas.Queries;
using Util.Applications;
using Agents.Data;
using Agents.Data.Conditions.Sales;
using Agents.Distributions.Domain.Services.Abstractions;
using Agents.Members.Domain.Repositories;
using Agents.Sales.Domain.Models;
using Agents.Sales.Domain.Services.Abstractions;
using Agents.Sales.Domain.Repositories;
using Agents.Service.Dtos.Sales;
using Agents.Service.Dtos.Sales.Requests;
using Agents.Service.Dtos.Sales.Extensions;
using Agents.Service.Queries.Sales;
using Agents.Service.Abstractions.Sales;
using Microsoft.EntityFrameworkCore;
using Util.Exceptions;

namespace Agents.Service.Implements.Sales {
    /// <summary>
    /// 订单服务
    /// </summary>
    public class OrderService : DeleteServiceBase<Order, OrderDto, OrderQuery>, IOrderService {
        /// <summary>
        /// 初始化订单服务
        /// </summary>
        public OrderService(IAgentsUnitOfWork unitOfWork, IOrderRepository orderRepository, IOrderManager orderManager, IMemberRepository memberRepository, IAgentManager agentManager, ICommissionManager commissionManager)
            : base(unitOfWork, orderRepository) {
            UnitOfWork = unitOfWork;
            OrderRepository = orderRepository;
            OrderManager = orderManager;
            MemberRepository = memberRepository;
            AgentManager = agentManager;
            CommissionManager = commissionManager;
        }

        /// <summary>
        /// 工作单元
        /// </summary>
        public IAgentsUnitOfWork UnitOfWork { get; }
        /// <summary>
        /// 订单仓储
        /// </summary>
        public IOrderRepository OrderRepository { get; set; }
        /// <summary>
        /// 订单管理器
        /// </summary>
        public IOrderManager OrderManager { get; set; }
        /// <summary>
        /// 会员仓储
        /// </summary>
        public IMemberRepository MemberRepository { get; }
        /// <summary>
        /// 代理管理器
        /// </summary>
        public IAgentManager AgentManager { get; }

        /// <summary>
        /// 佣金管理器
        /// </summary>
        public ICommissionManager CommissionManager { get; }


        /// <summary>
        /// 分页查询
        /// </summary>
        /// <param name="parameter">查询参数</param>
        public async Task<PagerList<OrderDto>> PagerQueryOrderAsync(OrderQuery parameter) {
            if (parameter == null)
                return new PagerList<OrderDto>();
            var query = await CreateQuery(parameter);
            var queryable = OrderRepository.FindAsNoTracking().Where(query);
            queryable = Filter(queryable, parameter);
            return (queryable.ToPagerList(query.GetPager())).Convert(ToDto);
        }

        /// <summary>
        /// 创建查询对象
        /// </summary>
        /// <param name="param">查询参数</param>
        protected new async Task<IQueryBase<Order>> CreateQuery(OrderQuery param) {
            Agent currentAgent = await AgentManager.GetCurrentAgentAsync();
            var queryCondition = new OrderQueryCondition(currentAgent);
            return new Query<Order>(param)
                .Where(queryCondition)
                .WhereIfNotEmpty(t => t.Type == param.Type)
                .WhereIfNotEmpty(t => t.PayType == param.PayType)
                .WhereIfNotEmpty(t => t.State == param.State)
                .WhereIfNotEmpty(t => t.OrderOutId == param.OrderOutId)
                .WhereIfNotEmpty(t => t.GoodsName.Contains(param.GoodsName))
                .WhereIfNotEmpty(t => t.Member.Name.Contains(param.MemberName))
                .WhereIfNotEmpty(t => t.Member.Agent.Name.Contains(param.AgentName));
        }

        /// <summary>
        /// 设置关联对象
        /// </summary>
        protected override IQueryable<Order> Filter(IQueryable<Order> queryable, OrderQuery parameter) {
            return queryable.Include(t => t.Member).Include(t => t.Member.Agent);
        }

        /// <summary>
        /// 异步获取订单
        /// </summary>
        public async Task<OrderDto> GetOrderByIdAsync(Guid id) {
            var entity = await OrderRepository.Find(t => t.Id == id).Include(t => t.Member).Include(t => t.Member.Agent)
                .FirstOrDefaultAsync();
            var result = entity.ToDto();
            return result;
        }

        /// <summary>
        /// 添加订单
        /// </summary>
        public async Task<Guid> CreateAsync(OrderCreateRequest request) {
            var member = await MemberRepository.SingleAsync(t => t.MemberOutId == request.MemberOutId);
            if (member == null) {
                throw new Warning("找不到会员信息");
            }
            var order = request.MapTo<Order>();
            order = await OrderManager.CreateOrderAsync(order, member);
            await UnitOfWork.CommitAsync();
            return order.Id;
        }

        /// <summary>
        /// 支付订单
        /// </summary>
        public async Task PayAsync(Guid orderId)
        {
            var entity = await OrderRepository.Find(t => t.Id == orderId).Include(t => t.Member)
                .Include(t => t.Member.Agent).FirstOrDefaultAsync();
            if (entity == null) {
                throw new Warning("找不到订单");
            }
            OrderManager.PayOrder(entity);
            await CommissionManager.CalcCommissionAsync(entity);
            await UnitOfWork.CommitAsync();
        }

        /// <summary>
        /// 修改订单
        /// </summary>
        public async Task UpdateAsync(OrderUpdateRequest request) {
            var entity = await OrderRepository.FindAsync(request.OrderId);
            request.MapTo(entity);
            await OrderRepository.UpdateAsync(entity);
            await UnitOfWork.CommitAsync();
        }

        /// <summary>
        /// 删除订单
        /// </summary>
        public async Task DeleteOrder(string ids) {
            await OrderManager.DeleteOrder(ids);
            await UnitOfWork.CommitAsync();
        }
    }
}