using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace NorthwindManager.Dtos
{
   public class MatchDto
    {
        public MetaDataDto MetaData { get; set; }           
        public InfoDto Info { get; set; }


    }
}
