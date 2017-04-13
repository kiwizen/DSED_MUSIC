using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using AccessMusicDB.Model;

namespace AccessMusicDB
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service.svc or Service.svc.cs at the Solution Explorer and start debugging.
    public class Service : IService
    {
        public string SqlConStr = 
            "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Music;" +
            "Integrated Security=True;Connect Timeout=30;Encrypt=False;" +
            "TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public IList<Owner> QueryOwner()
        {
            DataSet ds = new DataSet();
            using (SqlConnection sqlCon = new SqlConnection(SqlConStr))
            {
                try
                {
                    sqlCon.Open();
                    string sqlStr = "select Title, Text from TestTable";
                    SqlDataAdapter sqlDa = new SqlDataAdapter(sqlStr, sqlCon);
                    sqlDa.Fill(ds);
                }
                catch
                {
                    return null;
                }
                finally
                {
                    sqlCon.Close();
                }
            }

            List<Owner> OwnerList = new List<Owner>();
            DataTable dt = ds.Tables[0];
            foreach (DataRow dr in dt.Rows)
            {
                OwnerList.Add(new Owner()
                {
                    Title = dr["Title"] as string,
                    Text = dr["Text"] as string
                });
            }

            return OwnerList;
        }
    }
}
