using System;
using System.Runtime.Serialization;

namespace MusicSQLService.Model
{
    [DataContract]
    public class Owner
    {
        public static string PrimaryKey { get; } = "OwnerID";
        public static string FirstNameKey { get; } = "FirstName";
        public static string LastNameKey { get; } = "LastName";

        
        [DataMember]
        public string ID { get; set; } 

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        public Owner(){ }
    }
}