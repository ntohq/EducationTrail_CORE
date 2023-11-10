using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver;
using MongoDB.Bson;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Hosting.Internal;

namespace EducationTrail_Core.DBTesting;

public class DBTestingService : IHostedService
{
    private ILogger<DBTestingService> _logger;
    private IConfiguration _config;
    private MongoClient _client;
    private ApplicationLifetime applicationLifetime;
    public string test;

    public DBTestingService(ILogger<DBTestingService> logger, IConfiguration config, ApplicationLifetime lifeTime)
    {
        applicationLifetime = lifeTime;
        _logger = logger;
        _config = config;
        test = config.GetSection("test").Value ?? string.Empty;
        _client = new MongoClient(config.GetSection("MongoString").Value ?? string.Empty);
    }

    public async Task StartAsync(CancellationToken cancellationToken)
    {
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
    }
}
