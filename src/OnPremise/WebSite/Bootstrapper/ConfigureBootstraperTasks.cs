using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NCARB.Infrastructure.IdentityServer;
using NCARB.Infrastructure.IoC;

namespace Thinktecture.IdentityServer.Web.Bootstrapper
{
    [BootstrapTaskOrder(1)]
    internal class ConfigurePlugins : IBootstrapperTask
    {
        public void Execute(IContainerAdapter container)
        {
            container.AddPlugin<IdentityServicePlugin>();
        }
    }
}