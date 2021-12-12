using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace RiotManagerDb
{
    public class TeamDto
    {

        public List<BanDto> bans { get; set; }
        public ObjectivesDto objectives { get; set; }
        public int teamId { get; set; }
        public bool win { get; set; }
    }
}