using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace RiotManagerDb
{
    public class MetaDataDto
    {
 
        public string matchId { get; set; }
        public string dataVersion { get; set; }
               
        public List<string> participants { get; set; }
    }
}