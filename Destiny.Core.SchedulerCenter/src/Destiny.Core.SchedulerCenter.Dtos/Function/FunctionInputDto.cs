﻿using Destiny.Core.SchedulerCenter.Domain.Models.Function;
using Destiny.Core.SchedulerCenter.Shared.Attributes.AutoMapper;
using Destiny.Core.SchedulerCenter.Shared.Entity;
using System;
using System.ComponentModel;

namespace Destiny.Core.SchedulerCenter.Dtos.Function
{
    [SuktAutoMapper(typeof(FunctionEntity))]
    public class FunctionInputDto : InputDto<Guid>
    {
        [DisplayName("功能名称")]
        /// <summary>
        /// 功能名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [DisplayName("描述")]
        public string Description { get; set; }

        /// <summary>
        /// 是否可用
        /// </summary>
        [DisplayName("是否可用")]
        public bool IsEnabled { get; set; }

        /// <summary>
        /// 链接Url
        /// </summary>
        [DisplayName("链接Url")]
        public string LinkUrl { get; set; }
    }
}