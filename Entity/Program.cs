using Microsoft.Extensions.DependencyInjection;
using static Entity.Logic;

namespace Entity
{
    public class Program
    {
       static void Main(string[] args)
       {
            var services = new ServiceCollection();
            Startup.ConfigureServices(services);

             using (var serviceProvider = services.BuildServiceProvider())
             {
                    var programLogic = serviceProvider.GetRequiredService<ProgramLogic>();
                  programLogic.Run();
             }
       }
    }
}
