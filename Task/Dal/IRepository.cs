using System.Collections.Generic;
using System.Data;
using Task.Models;

namespace Task.Dal
{
    public interface IRepository
    {
        DataSet CreateDataSet(string query, string currentDatabaseName);
        int ExecuteDML(string query, string currentDatabaseName);
        IEnumerable<Column> GetColumns(DBEntity dBEntity);
        IEnumerable<Database> GetDatabases();
        IEnumerable<DBEntity> GetDBEntities(Database database, DBEntityType dbEntityType);
        IEnumerable<ProcedureParams> GetParams(Procedure procedure);
        IEnumerable<Procedure> GetProcedures(Database database);
        void LogIn(string server, string username, string password);
    }
}