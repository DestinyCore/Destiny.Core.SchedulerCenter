﻿using IdentityServer4.Stores;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Destiny.Core.SchedulerCenter.Domain.Models.IdentityServerFour;
using Destiny.Core.SchedulerCenter.Shared.Entity;
using Destiny.Core.SchedulerCenter.Shared.Extensions;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Destiny.Core.SchedulerCenter.IdentityServer4Store.Store
{

    public class ClientStoreBase : IClientStore
    {
        private readonly ILogger<ClientStoreBase> _logger;

        private readonly IEFCoreRepository<Client, Guid> _clientRepository;

        public ClientStoreBase(ILogger<ClientStoreBase> logger, IEFCoreRepository<Client, Guid> clientRepository)
        {
            _logger = logger;
            _clientRepository = clientRepository;
        }

        public async Task<IdentityServer4.Models.Client> FindClientByIdAsync(string clientId)
        {
            var client = await _clientRepository
                .NoTrackEntities.Where(x => x.ClientId == clientId)
                .Include(x => x.AllowedGrantTypes)
                .Include(x => x.RedirectUris)
                .Include(x => x.AllowedScopes)
                .Include(x => x.PostLogoutRedirectUris)
                .Include(x => x.ClientSecrets).SingleOrDefaultAsync();
            if (client == null)
                return null;
            var dto = client?.MapTo<IdentityServer4.Models.Client>();
            return dto;
        }
    }
}