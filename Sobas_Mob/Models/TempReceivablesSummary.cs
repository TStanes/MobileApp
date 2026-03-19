using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("TempReceivables_Summary")]
public partial class TempReceivablesSummary
{
    [Column("PartyUID")]
    public Guid PartyUid { get; set; }

    [Column("DivisionUID")]
    public Guid? DivisionUid { get; set; }

    [Column("Dr_UnAdjAmt", TypeName = "decimal(38, 3)")]
    public decimal? DrUnAdjAmt { get; set; }
}
