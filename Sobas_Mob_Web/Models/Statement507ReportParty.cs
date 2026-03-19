using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Keyless]
[Table("Statement507ReportParty")]
public partial class Statement507ReportParty
{
    [Column("ReportPartyUID")]
    public Guid ReportPartyUid { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? PartyCode { get; set; }
}
