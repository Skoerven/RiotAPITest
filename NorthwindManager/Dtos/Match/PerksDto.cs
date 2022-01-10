using System.Collections.Generic;

namespace NorthwindManager.Dtos
{
    public class PerksDto
    {
        public PerkStatsDto MyProperty { get; set; }
        public List<PerkStyleDto> styles { get; set; }
    }
}