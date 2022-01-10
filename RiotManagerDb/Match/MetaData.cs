using SQLiteNetExtensions.Attributes;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;

namespace RiotManagerDb
{
    public class MetaData
    {
 
        public long Id { get; set; }
        public string dataVersion { get; set; }

        [NotMapped]
        private List<string> participants;
        [NotMapped]
        public List<string> Participants
        {
            get { return JsonSerializer.Deserialize<List<string>>(partici); }
            set { participants = value;
               partici = JsonSerializer.Serialize(participants);
            }
        }

    
        public string partici { get; set; }
    }
}