using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MusicSQLService.Model;
using System.Data;
using System.Data.SqlClient;

namespace MusicSQLService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service.svc or Service.svc.cs at the Solution Explorer and start debugging.
    public class Service : IService
    {
        public string SQLConnectionString =
            "Server = tcp:kiwizen-dsed.database.windows.net,1433;Initial Catalog = DSED; " +
            "Persist Security Info=False;User ID = kiwizen-dsed; Password=Monday99; " +
            "MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout = 30";
        /*
        "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Music;" + 
        "Integrated Security=True;Connect Timeout=30;Encrypt=False;" + 
        "TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        */
        public IList<Owner> QueryOwner()
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
                    return null;
                }
                finally
                {
                    sqlConnection.Close();
                }
            }

            List<Owner> ownerList = new List<Owner>();
            DataTable table = dataset.Tables[0];
            foreach (DataRow datarow in table.Rows)
            {
                ownerList.Add(new Owner()
                {
                    ID = datarow[Owner.PrimaryKey].ToString(),
                    FirstName = datarow[Owner.FirstNameKey] as string,
                    LastName = datarow[Owner.LastNameKey] as string
                });
            }
            return ownerList;
        }
    }
}
