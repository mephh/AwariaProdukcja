using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using Dapper;

namespace SQLiteLib
{
    public class SqliteDataAccess
    {
        public static List<ProblemModel> LoadProblems()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<ProblemModel>("SELECT * FROM Awarie", new DynamicParameters());
                return output.ToList();
            }
            return null;
        }
        
        public static void SaveProblem(ProblemModel problem)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("INSERT into Awarie(Tester, Start, InterventionStart, Stop, TypeOfIssue, RootCause) values (@Tester, @Start, @InterventionSTart, @Stop, @TypeOfIssue, @RootCause)", problem);
            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
