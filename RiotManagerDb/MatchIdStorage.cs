using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace RiotManagerDb
{
    public class MatchIdStorage
    {
        [AutoIncrement]
        public long Id { get; set; }
        public string matchid { get; set; }
        public string  puuid { get; set; }
        
    }
}
