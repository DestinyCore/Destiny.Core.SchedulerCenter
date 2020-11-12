﻿using Destiny.Core.SchedulerCenter.IdentityServerFour.Resources;
using Destiny.Core.SchedulerCenter.Shared.Entity;
using System;
using System.ComponentModel;

namespace Destiny.Core.SchedulerCenter.IdentityServerFour
{
    /// <summary>
    /// api授权范围
    /// </summary>
    [DisplayName("api授权范围")]
    public abstract class ApiScopeBase : ResourceBase, IEntity<Guid>
    {
        /// <summary>
        /// 是否必须
        /// </summary>
        [Description("是否必须")]
        public bool Required { get; set; }

        /// <summary>
        /// 是否强调显示
        /// </summary>
        [Description("是否强调显示")]
        public bool Emphasize { get; set; }

        ///// <summary>
        ///// 用户声明
        ///// </summary>
        //public List<ApiScopeClaimBase> UserClaims { get; set; }

        ///// <summary>
        ///// 属性
        ///// </summary>
        //public List<ApiScopePropertyBase> Properties { get; set; }
    }
}