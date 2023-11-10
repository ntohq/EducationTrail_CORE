using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver.Core.Configuration;
using Amazon.Runtime.Internal.Util;
using MongoDB.Driver.Core.Connections;
using Microsoft.Extensions.Logging;

namespace EducationTrail_Core.Services;

public class ConnectionService
{
    private readonly string connectionString;
    public MongoClient _client;
    private Logger _logger;
    

    ConnectionService(Logger logger) 
    {
        connectionString = "";
        _logger = logger;
        _client = new MongoClient(connectionString);
    }
    
    public IMongoDatabase GetDatabase(string databaseName)
    {
        return _client.GetDatabase(databaseName);
    }

    public IMongoCollection<BsonDocument> GetCollection(IMongoDatabase mongoDatabase, string collectionName)
    {
        return mongoDatabase.GetCollection<BsonDocument>("");
    }


}


// var connectionString = Environment.GetEnvironmentVariable("MONGODB_URI");
// if (connectionString == null)
// {
//     Console.WriteLine("You must set your 'MONGODB_URI' environment variable. To learn how to set it, see https://www.mongodb.com/docs/drivers/csharp/current/quick-start/#set-your-connection-string");
//     Environment.Exit(0);
// }
// var client = new MongoClient(connectionString);
// var collection = client.GetDatabase("sample_mflix").GetCollection<BsonDocument>("movies");
// var filter = Builders<BsonDocument>.Filter.Eq("title", "Back to the Future");
// var document = collection.Find(filter).First();
// Console.WriteLine(document);