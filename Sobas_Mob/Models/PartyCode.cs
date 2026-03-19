using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("partyCodes")]
public partial class PartyCode
{
    [Column("partyCode")]
    [StringLength(100)]
    [Unicode(false)]
    public string? PartyCode1 { get; set; }
}
