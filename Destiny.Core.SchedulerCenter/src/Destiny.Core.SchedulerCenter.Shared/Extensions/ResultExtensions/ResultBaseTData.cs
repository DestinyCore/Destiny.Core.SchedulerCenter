﻿using System.Collections.Generic;

namespace Destiny.Core.SchedulerCenter.Shared.Extensions.ResultExtensions
{
    public abstract class ResultBaseTData<TData> : ResultBase, IResultData<TData>
    {
        public virtual IEnumerable<TData> Data { get; set; }
    }
}