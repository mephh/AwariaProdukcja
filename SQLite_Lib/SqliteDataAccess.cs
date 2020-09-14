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
                cnn.Execute("INSERT into Testers(Tester, Start, InterventionStart, Stop, Downtime, TypeOfIssue, RootCause, Technician) values (@Tester, @Start, @InterventionSTart, @Stop, @Downtime, @TypeOfIssue, @RootCause, @TechnicianID)", problem);
            }
        }

        public static void SaveProblemSQL(ProblemModel problem)
        {
            using (IDbConnection cnn = new System.Data.SqlClient.SqlConnection(LoadConnectionString()))
            {
                cnn.Open();
                cnn.Execute("INSERT into Testers(Tester, Start, InterventionStart, Stop, Downtime, TypeOfIssue, RootCause, Technician) values (@Tester, @Start, @InterventionSTart, @Stop, @Downtime, @TypeOfIssue, @RootCause, @TechnicianID)", problem);
            }
        }

        private static string LoadConnectionString(string id = "ReportsDB")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
