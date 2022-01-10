using SQLite;
using System.Collections.Generic;

namespace RiotManagerDb
{
    public class Perks
    {
        [AutoIncrement]
        public long Id { get; set; }
        public long ParticipantId { get; set; }
        public PerkStats perkStats { get; set; }
        public long  PerkstylesID { get; set; }
    }
}