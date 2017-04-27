using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MusicDBService.Model;
using System.Data;
using System.Data.SqlClient;
using MusicDBService.View;

namespace MusicDBService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "MusicDBService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select MusicDBService.svc or MusicDBService.svc.cs at the Solution Explorer and start debugging.
    public class MusicDBService : IMusicDBService
    {

        //public delegate void ProcessRecordHandler(SqlDataReader record);


        /*
        "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Music;" +
        "Integrated Security=True;Connect Timeout=30;Encrypt=False;" +
        "TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        */
        /*
        void DoWork()
        {
        }
        */
        public void ProcessRecord(ViewModelClass model)
        {
            string SQLConnectionString =
            "Server = tcp:kiwizen-dsed.database.windows.net,1433;Initial Catalog = DSED; " +
            "Persist Security Info=False;User ID = kiwizen-dsed; Password=Monday99; " +
            "MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout = 30";
            //DataSet dataset = new DataSet();
            using (SqlConnection sqlConnection = new SqlConnection(SQLConnectionString))
            {
                try
                {
                    string SelectAllQuery = "select OwnerID, FirstName, LastName from Owner";

                    sqlConnection.Open();
                    using (SqlCommand command = new SqlCommand(SelectAllQuery, sqlConnection))
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        model.Clear();
                        while (reader.Read())
                        {

                            model.Add( new
                            {
                                LastName = reader[DBString.LastNameKey].ToString(),
                                FirstName = reader[DBString.FirstNameKey].ToString()
                            });
                        }
                    }
                    sqlConnection.Close();
                }
                catch
                {
                    throw new Exception("SQL Database Error Exception.");

                }
                finally
                {
                    if (sqlConnection != null)
                        sqlConnection.Close();
                }
            }
        }


        /*
        void GetOwnerRecord()
        {
            DataSet dataset = new DataSet();
            using (SqlConnection sqlConnection = new SqlConnection(SQLConnectionString))
            {
                try
                {
                    sqlConnection.Open();
                    string sqlStr = "select OwnerID, FirstName, LastName from Owner";
                    SqlDataAdapter sqlDa = new SqlDataAdapter(sqlStr, sqlConnection);
                    sqlDa.Fill(dataset);
                }
                catch
                {
                    throw new Exception("SQL Database Error Exception.");

                }
                finally
                {
                    if(sqlConnection != null )
                        sqlConnection.Close();
                }

            }

            /*
            DataTable table = dataset.Tables[0];
            foreach (DataRow datarow in table.Rows)
            {
                ClientMethod(new Owner()
                {
                    ID = datarow[DBString.PrimaryKey].ToString(),
                    FirstName = datarow[DBString.FirstNameKey] as string,
                    LastName = datarow[DBString.LastNameKey] as string
                });
            }
            */
            //return
        //}
        
    }
}
