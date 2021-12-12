using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RiotManagerDb
{
   public class MatchDto
    {
        public MetaDataDto MetaData { get; set; }           
        public InfoDto Info { get; set; }


    }
}
