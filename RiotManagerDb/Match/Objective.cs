using SQLite;
using SQLiteNetExtensions.Attributes;

namespace RiotManagerDb
{
    public class Objective
    {
        [AutoIncrement]
        public long Id { get; set; }

        public bool first { get; set; }
        public int kills { get; set; }
    }
}