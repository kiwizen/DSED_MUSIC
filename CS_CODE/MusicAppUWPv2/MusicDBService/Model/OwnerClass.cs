using System.Runtime.Serialization;

namespace MusicDBService.Model
{
    public class Owner
    {
        [DataMember]
        public string ID { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        public Owner() { }
    }
}