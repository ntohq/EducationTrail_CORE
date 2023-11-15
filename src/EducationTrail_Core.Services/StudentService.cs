using Amazon.Runtime.Internal.Util;
using EducationTrail_Core.Abstracts;

namespace EducationTrail_Core.Services;

public class StudentService : IStudent
{   
    private ConnectionService _client;
    private ILogger _logger;

    StudentService(ConnectionService client, ILogger logger)
    {
        _client = client;
        _logger = logger;
    }

    public Student GetStudent(string name)
    {
    }
}