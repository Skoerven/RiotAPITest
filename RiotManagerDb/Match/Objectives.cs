using SQLite;
using SQLiteNetExtensions.Attributes;

namespace RiotManagerDb
{
    public class Objectives
    {
        [AutoIncrement]
        public long Id { get; set; }
        public long TeamId { get; set; }
        //[ForeignKey(typeof(Objective)), OneToOne]
        public long baronId { get; set; }
        public Objective baron { get; set; }
        //[ForeignKey(typeof(Objective)), OneToOne]
        public long championId { get; set; }
        public Objective champion { get; set; }
        //[ForeignKey(typeof(Objective)), OneToOne]
        public long dragonId { get; set; }
        public Objective dragon { get; set; }
        //[ForeignKey(typeof(Objective)), OneToOne]
        public long inhibitorId { get; set; }
        public Objective inhibitor { get; set; }
        //[ForeignKey(typeof(Objective)), OneToOne]
        public long riftHeraldId { get; set; }
        public Objective riftHerald { get; set; }
        //[ForeignKey(typeof(Objective)), OneToOne]
        public long towerId { get; set; }
        public Objective tower { get; set; }

    }
}