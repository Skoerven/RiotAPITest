using System.Collections.Generic;

namespace RiotManagerDb
{
    public class PerksDto
    {
        public PerkStatsDto MyProperty { get; set; }
        public List<PerkStyleDto> styles { get; set; }
    }
}