using Microsoft.Extensions.DependencyInjection;

namespace dependancy
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var serviceProvider = new ServiceCollection()
                .AddScoped<ICarDetails,FirstCar>()
                .AddScoped<ICarDetails, SecondCar>()
                .AddSingleton<DefaultCar>()
                .BuildServiceProvider();


            var defaultCar = serviceProvider.GetRequiredService<DefaultCar>();  
            defaultCar.Run();   
        }
        
      
    }
}
