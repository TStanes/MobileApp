using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("ConsolidatedMonthlyLedger")]
public partial class ConsolidatedMonthlyLedger
{
    [Column("CMLUID")]
    public Guid Cmluid { get; set; }

    public int Month { get; set; }

    public int Year { get; set; }

    [StringLength(9)]
    [Unicode(false)]
    public string AccountType { get; set; } = null!;

    [Column("ScheduleUID")]
    public Guid ScheduleUid { get; set; }

    [Column("AccountGroupUID")]
    public Guid AccountGroupUid { get; set; }

    [Column("AccountUID")]
    public Guid AccountUid { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal DebitAmt { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal CreditAmt { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime AsOnDate { get; set; }

    public bool DelFlag { get; set; }

    public bool IsActive { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string CreatedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime CreatedDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ModifiedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ModifiedDate { get; set; }
}
