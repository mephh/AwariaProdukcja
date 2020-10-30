using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Data.SqlClient;
using System.Linq;
using Dapper;

namespace SQLLib
{
    public class SqlDataAccess
    {
        public static List<ProblemModel> LoadProblems()
        {
            using (SqlConnection cnn = new SqlConnection(LoadConnectionString()))
            {
                var output = cnn.Query<ProblemModel>("SELECT * FROM Awarie", new DynamicParameters());
                return output.ToList();
            }
        }
        
        public static void SaveProblemSQL(ProblemModel problem)
        {
            using (SqlConnection cnn = new SqlConnection(LoadConnectionString()))
            {
                cnn.Open();
                cnn.Execute("INSERT into Testers(Tester, Start, InterventionStart, Stop, Downtime, TypeOfIssue, RootCause, Technician) values (@Tester, @Start, @InterventionSTart, @Stop, @Downtime, @TypeOfIssue, @RootCause, @TechnicianID)", problem);
            }
        }

        private static string LoadConnectionString(string id = "ReportsDB")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        public static void UpdateRowSQL(StatusModel sm)
        {
            using (SqlConnection cnn = new SqlConnection(LoadConnectionString()))
            {
                cnn.Open();
                //cnn.Execute("UPDATE ComputerNames (PC, Name, Status) values (@PC, @Name, @Status)", sm);
                cnn.Execute("IF EXISTS(SELECT * FROM ComputerNames WHERE PC = @PC)" +
                    "                  UPDATE ComputerNames SET Status = @Status, Name = @Name where PC = @PC;" +
                    "        ELSE" +
                    "        INSERT ComputerNames(PC, Name, Status)" +
                    "        VALUES(@PC, @Name, @Status);", sm);
            }
        }

        string upsertCommand = @"CREATE PROCEDURE s_AccountDetails_Upsert ( @Email nvarchar(4000), @Etc nvarchar(max) )
                                AS
                                SET TRANSACTION ISOLATION LEVEL SERIALIZABLE;
                                BEGIN TRAN


                                IF EXISTS(SELECT* FROM dbo.AccountDetails WITH (UPDLOCK) WHERE Email = @Email)


                                 UPDATE dbo.AccountDetails
                                 SET Etc = @Etc
                                 WHERE Email = @Email;

                                ELSE

                                 INSERT dbo.AccountDetails(Email, Etc)
                                 VALUES(@Email, @Etc );

                                COMMIT";


    }
}
