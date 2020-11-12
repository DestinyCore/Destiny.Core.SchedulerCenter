﻿using Destiny.Core.SchedulerCenter.Dtos;
using Destiny.Core.SchedulerCenter.Shared;
using Destiny.Core.SchedulerCenter.Shared.OperationResult;
using System;
using System.Threading.Tasks;

namespace Destiny.Core.SchedulerCenter.Application
{
    public interface IUserContract : IScopedDependency
    {
        /// <summary>
        /// 新增用户
        /// </summary>
        /// <returns></returns>
        Task<OperationResponse> InsertAsync(UserInputDto input);

        /// <summary>
        /// 修改用户
        /// </summary>
        /// <returns></returns>
        Task<OperationResponse> UpdateAsync(UserUpdateInputDto input);

        /// <summary>
        /// 删除用户及对应权限
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<OperationResponse> DeleteAsync(Guid id);

        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<OperationResponse> LoadUserFormAsync(Guid id);
    }
}