using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("BudgetM_Data")]
public partial class BudgetMDatum
{
    [Column("BudgetUID")]
    public Guid BudgetUid { get; set; }

    [Column("BranchUID")]
    public Guid BranchUid { get; set; }

    [Column("DivisionUID")]
    public Guid DivisionUid { get; set; }

    [Column("SOUID")]
    public Guid Souid { get; set; }

    [Column("FYear")]
    public int Fyear { get; set; }

    [Column("ItemUID")]
    public Guid ItemUid { get; set; }

    [Column("FMonth")]
    public DateOnly Fmonth { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal BudgetTotalQty { get; set; }

    [Column("NR", TypeName = "decimal(18, 3)")]
    public decimal Nr { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal MonthlyQty { get; set; }

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
