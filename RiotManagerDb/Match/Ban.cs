using SQLite;

namespace RiotManagerDb
{
    public class Ban
    {
        [AutoIncrement]
        public long Id { get; set; }
        public long TeamId { get; set; }
        public int championId { get; set; }
        public int pickTurn { get; set; }
    }
}