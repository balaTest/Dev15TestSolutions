using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;

namespace WebApp_Anc20_core_NoAuth_1.Models
{
    public class BloggingContextFactory : IDbContextFactory<BloggingContext>
    {
        public BloggingContext Create(string[] args) =>
            Program.BuildWebHost(args).Services.GetRequiredService<BloggingContext>();
    }

}
