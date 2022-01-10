using SQLite;
using System.Collections.Generic;

namespace RiotManagerDb
{
    public class PerkStyle
    {
        [AutoIncrement]
        public long Id { get; set; }
        public long PerksId { get; set; }
        public string description { get; set; }
        public long PerkselectionsID { get; set; }
        public int style { get; set; }
    }
}