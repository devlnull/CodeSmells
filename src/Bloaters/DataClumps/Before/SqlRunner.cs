namespace Bloaters.DataClumps.Before;

public class SqlRunner
{
    string DatabaseName { get; }
    string UserId { get; }
    string Password { get; }
    string CredentialType { get; }

    public SqlRunner(string databaseName, string userId, string password, string credentialType)
    {
        DatabaseName = databaseName;
        UserId = userId;
        Password = password;
        CredentialType = credentialType;
    }

    public Task ExecuteAsync(string query)
    {
        //connect to database
        //execute command
        return Task.CompletedTask;
    }
}