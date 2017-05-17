using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;

namespace WebApp_Anc20_core_IndAuth_1.Identity.Data
{
    public class IdentityServiceDbContextFactory : IDbContextFactory<IdentityServiceDbContext>
    {
        public IdentityServiceDbContext Create(string[] args) =>
            Program.BuildWebHost(args).Services.GetRequiredService<IdentityServiceDbContext>();
    }
}
