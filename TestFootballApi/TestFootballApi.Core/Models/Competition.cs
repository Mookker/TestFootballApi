using System;
using System.Runtime.Serialization;

namespace TestFootballApi.Core.Models
{
    [DataContract]
    public class Competition
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Caption { get; set; }
        [DataMember]
        public string League { get; set; }
        [DataMember]
        public string Year { get; set; }
        [DataMember]
        public int NumberOfTeams { get; set; }
        [DataMember]
        public int NumberOfGames { get; set; }
        [DataMember]
        public DateTime LastUpdated { get; set; }
    }
}
