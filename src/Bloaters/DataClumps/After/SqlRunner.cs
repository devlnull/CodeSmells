namespace Bloaters.DataClumps.After;

public class SqlRunner
{
    private SqlSettings SqlSettings { get; }
    
    public SqlRunner(SqlSettings sqlSettings)
    {
        SqlSettings = sqlSettings;
    }

    public Task ExecuteAsync(string query)
    {
        //connect to database
        //execute command
        return Task.CompletedTask;
    }
}