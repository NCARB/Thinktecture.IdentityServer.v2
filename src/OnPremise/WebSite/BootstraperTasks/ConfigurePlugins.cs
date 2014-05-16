using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NCARB.Infrastructure.IdentityServer;
using NCARB.Infrastructure.IoC;
using Thinktecture.IdentityServer.Repositories;

namespace Thinktecture.IdentityServer.Web.BootstraperTasks
{
    [BootstrapTaskOrder(1)]
    public class ConfigurePlugins : IBootstrapperTask
    {

        public IUserRepository UserRepository { get; set; }

        public void Execute(IContainerAdapter container)
        {
            container.AddPlugin<IdentityServicePlugin>();
            container.Configure<IdentityServicePlugin>().WithUserRepository<ProviderUserRepository>();
            container.RegisterSingleton<IUserManagementRepository, ProviderUserManagementRepository>();
        }

    }
}