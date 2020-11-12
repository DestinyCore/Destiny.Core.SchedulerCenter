﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Destiny.Core.SchedulerCenter.Shared;
using System;

namespace Destiny.Core.SchedulerCenter.Domain.Models
{
    public class UserClaimConfiguration : EntityMappingConfiguration<UserClaimEntity, Guid>
    {
        public override void Map(EntityTypeBuilder<UserClaimEntity> b)
        {
            b.HasKey(o => o.Id);
            b.Property(o => o.IsDeleted).HasDefaultValue(false);
            b.Property(o => o.UserId);
            b.ToTable("UserClaim");
        }
    }
}