using System;

namespace RiotManagerDb
{
    public class Summoner
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
