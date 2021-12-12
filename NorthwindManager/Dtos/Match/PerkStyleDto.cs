using System.Collections.Generic;

namespace RiotManagerDb
{
    public class PerkStyleDto
    {
        public string description { get; set; }
        public List<PerkStyleSelectionDto> selections { get; set; }
        public int style { get; set; }
    }
}