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
        public virtual DbSet<MatchIdStorage> MatchesInfo { get; set; }
        public virtual DbSet<Match> Matches { get; set; }
        public virtual DbSet<Info> Infos { get; set; }
        public virtual DbSet<MetaData> MetaDatas { get; set; }
        public virtual DbSet<Team> Teams { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlite("data source=C:\\Temp\\rito.sqlite");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    }
}
