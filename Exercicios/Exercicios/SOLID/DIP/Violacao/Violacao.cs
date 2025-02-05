using Exercicios.Exercicio_5.Solucao;

public class BusinessLogic
{
    private readonly SQLServer _database;

    public BusinessLogic()
    {
        _database = new SQLServer();
    }

    public void AddData(string data)
    {
        _database.Save(data);
    }
}

public class SQLServer 
{
    public void Save(string data)
    {
        Console.WriteLine($"Saving '{data}' to SQLServer database");
    }
}


public class Oracle 
{
    public void Save(string data)
    {
        Console.WriteLine($"Saving '{data}' to SQLOracle database");
    }
}