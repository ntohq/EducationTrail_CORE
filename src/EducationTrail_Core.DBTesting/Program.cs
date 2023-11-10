using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using MongoDB.Driver;

namespace EducationTrail_Core.DBTesting;

public class Program
{
    public static IHostBuilder CreateHostBuilder(string[] args)
    {
        return Host.CreateDefaultBuilder(args).ConfigureServices((_, servies) => {
            servies.AddHostedService<DBTestingService>().AddSingleton<MongoClient>("mongodb+srv://DBTesting:!tAiv5HppzKL#Pp@ep-main.3figl.mongodb.net/?retryWrites=true&w=majority");
        }).ConfigureLogging((_, logging) => {
            logging.AddConfiguration(_.Configuration.GetSection("Logging"));
            logging.AddConsole();
        });
    }

    public static void Main(string[] args)
    {
        var host = CreateHostBuilder(args).Build();
        host.StartAsync();
        return;
    }
}