

namespace Exercicios.Exercicio_5.Solucao
{
    public class BusinessLogic
    {
        private readonly ISqlDatabase _database;

        public BusinessLogic(ISqlDatabase data)
        {
            _database = data;
        }

        public void AddData(string data)
        {
            _database.Save(data);
        }
    }

    public class SQLServer : ISqlDatabase
    {
        public void Save(string data)
        {
            Console.WriteLine($"Saving '{data}' to SQLServer database");
        }
    }

    public class Oracle : ISqlDatabase
    {
        public void Save(string data)
        {
            Console.WriteLine($"Saving '{data}' to SQLOracle database");
        }

    }

    public interface ISqlDatabase
    {
        void Save(string data);
    }


}
