using SQLite;

namespace RiotManagerDb
{
    public class PerkStats
    {
        [AutoIncrement]
        public long Id { get; set; }
        public long PerksId { get; set; }
        public int defense { get; set; }
        public int flex { get; set; }
        public int offense { get; set; }
    }
}