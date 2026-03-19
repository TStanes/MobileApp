using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobas_Mob
{
    public class PartyDto
    {
        public string? PartyCode { get; set; }
        public string? PartyName { get; set; }
        // 👇 This will be shown in dropdown
        public string DisplayText => $"{PartyCode} - {PartyName}";
    }
}
