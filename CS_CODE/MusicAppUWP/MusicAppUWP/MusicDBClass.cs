using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicAppUWP
{
    class MusicDBSQLService
    {
        private static string ConnectionString = 
            @"Server=tcp:kiwizen-dsed.database.windows.net,1433;" + 
             "Initial Catalog=DSED;Persist Security Info=False;User ID=kiwizen-dsed;Password=Monday99;"+
             "MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
    }




    class MusicOwnerTable
    {
        static string PrimaryKey { get; } = "OwnerID";
        static string FirstName { get; } = "FirstName";
        static string LastName { get; } = "LastName";
    }


    class MusicCDClass
    {
        static string PrimaryKey { get; } = "CDID";
        static string OwnerID { get; } = "OwnerIDFK";
        static string Name { get; } = "Name";
        static string Artist { get; } = "Artist";
        static string Genre { get; } = "Genre";
    }
}
