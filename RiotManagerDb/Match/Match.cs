using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RiotManagerDb
{
   public class Match
    {
        [AutoIncrement]
        public long Id { get; set; }
        public string MatchId { get; set; }
        public long MetaDataId { get; set; }           
        public long InfoId { get; set; }


    }
}   
