using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Entity.Logic;

namespace Entity
{
    public class Startup
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<FakultetDbContext>();
            services.AddScoped<StudentService>();
            services.AddScoped<KontaktService>();
            services.AddScoped<ProgramLogic>(); ;
        }


    }
}
