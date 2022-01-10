using SQLite;

namespace RiotManagerDb
{
    public class PerkStyleSelection
    {
        [AutoIncrement]
        public long Id { get; set; }
        public long PerkStyleId { get; set; }
        public int perk { get; set; }
        public int var1 { get; set; }
        public int var2 { get; set; }
        public int var3 { get; set; }
    }
}