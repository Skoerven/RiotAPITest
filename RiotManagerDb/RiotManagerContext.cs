using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiotManagerDb
{
    public partial class RiotManagerContext : DbContext
    {
        public RiotManagerContext()
        {
        }

        public RiotManagerContext(DbContextOptions<RiotManagerContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Summoner> Summoners { get; set; }
        public virtual DbSet<Matches> Matches { get; set; }
        public virtual DbSet<Participant> Participants { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlite("data source=E:\\Temp\\rito.sqlite");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Matches>().HasKey(x => x.matchid);
            modelBuilder.Entity<Participant>().HasKey(x => new {matchid = x.matchid, puuid = x.puuid });


        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    }
}
