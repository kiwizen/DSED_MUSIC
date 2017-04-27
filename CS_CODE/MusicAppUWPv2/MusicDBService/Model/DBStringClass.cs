using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicDBService.Model
{
    public class DBString
    {
        public static string PrimaryKey { get; } = "OwnerID";
        public static string FirstNameKey { get; } = "FirstName";
        public static string LastNameKey { get; } = "LastName";
    }
}