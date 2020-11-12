﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Destiny.Core.SchedulerCenter.Application.Identity.Role;
using Destiny.Core.SchedulerCenter.AspNetCore.ApiBase;
using Destiny.Core.SchedulerCenter.Dtos.Identity.Role;
using Destiny.Core.SchedulerCenter.Shared.AjaxResult;
using Destiny.Core.SchedulerCenter.Shared.Audit;
using Destiny.Core.SchedulerCenter.Shared.Entity;
using Destiny.Core.SchedulerCenter.Shared.Extensions;
using Destiny.Core.SchedulerCenter.Shared.OperationResult;
using System;
using System.ComponentModel;
using System.Threading.Tasks;

namespace Destiny.Core.SchedulerCenter.API.Controllers
{
    /// <summary>
    /// 角色管理
    /// </summary>
    [Description("角色管理")]
    public class RoleController : ApiControllerBase
    {
        private readonly IRoleContract _roleContract = null;
        private readonly ILogger<RoleController> _logger = null;

        public RoleController(IRoleContract roleContract, ILogger<RoleController> logger)
        {
            _roleContract = roleContract;
            _logger = logger;
        }

        /// <summary>
        /// 添加角色
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPost]
        [Description("添加角色")]
        [AuditLog]
        public async Task<AjaxResult> CreateAsync([FromBody] RoleInputDto input)
        {
            return (await _roleContract.CreateAsync(input)).ToAjaxResult();
        }

        /// <summary>
        /// 修改角色
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        [HttpPut]
        [Description("修改角色")]
        [AuditLog]
        public async Task<AjaxResult> UpdateAsync([FromBody] RoleInputDto input)
        {
            return (await _roleContract.UpdateAsync(input)).ToAjaxResult();
        }

        /// <summary>
        /// 删除角色
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Description("删除角色")]
        [AuditLog]
        public async Task<AjaxResult> DeleteAsync(Guid id)
        {
            return (await _roleContract.DeleteAsync(id)).ToAjaxResult();
        }
        /// <summary>
        /// 分页获取角色
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Description("分页获取角色")]
        public async Task<PageList<RoleOutPutPageDto>> GetPageAsync([FromBody] PageRequest request)
        {
            return (await _roleContract.GetPageAsync(request)).PageList();
        }
        /// <summary>
        /// 角色分配权限
        /// </summary>
        /// <returns></returns>
        [Description("角色分配权限")]
        [HttpPost]
        public async Task<AjaxResult> AllocationRoleMenuAsync([FromBody] RoleMenuInputDto dto)
        {
            return (await _roleContract.AllocationRoleMenuAsync(dto)).ToAjaxResult();
        }
    }
}