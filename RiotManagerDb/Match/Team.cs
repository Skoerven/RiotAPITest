    using SQLite;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace RiotManagerDb
{
    public class Team
    {
        [AutoIncrement]
        public long Id { get; set; }
        public long banID { get; set; }
        public long objectiveId { get; set; }
        public int teamId { get; set; }
        public bool win { get; set; }
    }
}