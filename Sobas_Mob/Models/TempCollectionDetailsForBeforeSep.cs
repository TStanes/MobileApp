using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("TempCollectionDetailsForBeforeSep")]
public partial class TempCollectionDetailsForBeforeSep
{
    [Column("PartyUID")]
    public Guid? PartyUid { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? PartyCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? PartyName { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? ConsCreditSep { get; set; }
}
