﻿using System.Reflection;

namespace Destiny.Core.SchedulerCenter.Shared.SuktReflection
{
    public class AssemblyFinder : FinderBase<Assembly>, IAssemblyFinder
    {
        protected override Assembly[] FindAllItems()
        {
            return AssemblyHelper.FindAllItems();
        }
    }
}