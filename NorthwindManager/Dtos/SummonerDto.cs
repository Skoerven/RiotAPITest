using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NorthwindManager.Dtos
{
    public class SummonerDto
    {
        public string AccountId { get; set; }
        public int ProfileIconId { get; set; }
        public long RevisionDate { get; set; }
        public string Name { get; set; }
        public string Id { get; set; }
        public string puuid { get; set; }
        public long SummonerLevel { get; set; }
    }
}
