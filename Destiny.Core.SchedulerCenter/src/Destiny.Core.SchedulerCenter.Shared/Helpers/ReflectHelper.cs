﻿using System;
using System.Reflection;

namespace Destiny.Core.SchedulerCenter.Shared.Helpers
{
    public static class ReflectHelper
    {
        public static Assembly[] GetAssemblies()
        {
            Assembly[] assemblies = null;

            if (null == assemblies || assemblies.Length == 0)
            {
                assemblies = AppDomain.CurrentDomain.GetAssemblies();
            }

            return assemblies ?? ArrayHelper.Empty<Assembly>();
        }
    }
}