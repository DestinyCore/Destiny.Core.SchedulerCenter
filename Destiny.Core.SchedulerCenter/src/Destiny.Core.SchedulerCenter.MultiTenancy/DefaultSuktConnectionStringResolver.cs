﻿using Microsoft.Extensions.DependencyInjection;
using Destiny.Core.SchedulerCenter.Shared.Extensions;
using System;

namespace Destiny.Core.SchedulerCenter.MultiTenancy
{
    public class DefaultSuktConnectionStringResolver : ISuktConnectionStringResolver
    {
        private readonly IServiceProvider _serviceProvider = null;
        private readonly TenantInfo _tenantInfo;

        public DefaultSuktConnectionStringResolver(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            this._tenantInfo = _serviceProvider.GetService<TenantInfo>();
        }

        public string Resolve()
        {
            Console.WriteLine(_tenantInfo.Name);
            string connectionString = "server=10.1.40.207;userid=test;pwd=pwd123456;database=Destiny.Core.SchedulerCenter;connectiontimeout=3000;port=3307;Pooling=true;Max Pool Size=300; Min Pool Size=5;";
            return connectionString;
        }
    }
}