using System.Runtime.Serialization;

namespace TestFootballApi.Core.Models
{
    [DataContract]
    public class Team
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Code { get; set; }
        [DataMember]
        public string ShortName { get; set; }
        [DataMember]
        public string SquadMarketValue { get; set; }
        [DataMember]
        public string CrestUrl { get; set; }
    }
}