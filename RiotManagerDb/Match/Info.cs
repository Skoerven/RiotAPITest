using System.Collections.Generic;

namespace RiotManagerDb
{
    public class Info
    {
        public long Id { get; set; }
        public long gameCreation { get; set; }
        public long gameDuration { get; set; }
        public long gameEndTimestamp { get; set; }
        public long gameId { get; set; }
        public string gameMode { get; set; }
        public string gameName { get; set; }
        public long gameStartTimestamp { get; set; }
        public string gameType { get; set; }
        public string gameVersion { get; set; }
        public int mapId { get; set; }
        public List<Participant> participants { get; set; }
        public string platformId { get; set; }
        public int queueId { get; set; }
        public long team1Id { get; set; }
        public long team2Id { get; set; }
        public string tournamentCode { get; set; }
    }
}