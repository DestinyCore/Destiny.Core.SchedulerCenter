﻿using Destiny.Core.SchedulerCenter.IdentityServerFour;
using Destiny.Core.SchedulerCenter.Shared.Entity;
using System;
using System.ComponentModel;

namespace Destiny.Core.SchedulerCenter.Domain.Models.IdentityServerFour
{
    /// <summary>
    /// 设备代码
    /// </summary>
    [DisplayName("设备代码")]
    public class DeviceFlowCodes : DeviceFlowCodesBase, IFullAuditedEntity<Guid>
    {
        #region 公共字段

        /// <summary>
        /// 创建人Id
        /// </summary>
        [DisplayName("创建人Id")]
        public Guid? CreatedId { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [DisplayName("创建时间")]
        public virtual DateTime CreatedAt { get; set; }

        /// <summary>
        /// 修改人ID
        /// </summary>
        [DisplayName("修改人ID")]
        public Guid? LastModifyId { get; set; }

        /// <summary>
        ///修改时间
        /// </summary>
        [DisplayName("修改时间")]
        public virtual DateTime LastModifedAt { get; set; }

        /// <summary>
        /// 是否删除
        /// </summary>
        [DisplayName("是否删除")]
        public bool IsDeleted { get; set; }

        #endregion 公共字段
    }
}