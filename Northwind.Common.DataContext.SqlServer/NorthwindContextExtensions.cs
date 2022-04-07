using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Northwind.Common.DataContext.SqlServer
{
    public static class NorthwindContextExtensions
    {
        public static IServiceCollection AddNorthwindContext(this IServiceCollection services, string relativePath = "..")
        {
            string databasePath = "Data Source=.;Initial Catalog=Northwind;Trusted_Connection=true;";

            services.AddDbContext<NorthwindContext>(options =>
                options.UseSqlServer(databasePath));

            return services;
        }
    }
}
