﻿using Destiny.Core.SchedulerCenter.Shared.Extensions.OrderExtensions;

namespace Destiny.Core.SchedulerCenter.Shared.PageParameter
{
    public class PageParameters
    {
        public PageParameters(int pageIndex, int pageSize)
        {
            PageIndex = pageIndex;
            PageSize = pageSize;
            OrderConditions = new OrderCondition[] { };
        }

        /// <summary>
        /// 分页索引
        /// </summary>

        public virtual int PageIndex { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        public virtual int PageSize { get; set; }

        /// <summary>
        /// 排序条件集合
        /// </summary>
        public OrderCondition[] OrderConditions { get; set; }
    }
}