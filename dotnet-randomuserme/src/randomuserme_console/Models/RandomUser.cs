using System;
using System.Runtime.Serialization;

namespace Models
{
    [DataContract]
    public class RandomUser
    {
        [DataMember(Name="gender")]
        public string Gender { get; set; }
        [DataMember(Name="email")]
        public string Email { get; set; }
        [DataMember(Name="dob")]
        public string DayOfBirth { get; set; }
        [DataMember(Name="nat")]
        public string Nationality { get; set; }
        [DataMember(Name="registered")]
        public string RegisteredAt { get; set; }
        [DataMember(Name="phone")]
        public string TEL { get; set; }
        [DataMember(Name="cell")]
        public string GSM { get; set; }
        [DataMember(Name="name")]
        public RandomUserName Name { get; set; }

        public RandomUser() 
        {
        }
        
    }
}