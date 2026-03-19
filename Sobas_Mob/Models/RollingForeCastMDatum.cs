using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("RollingForeCastM_Data")]
public partial class RollingForeCastMDatum
{
    [Column("RollingForeCastMUID")]
    public Guid RollingForeCastMuid { get; set; }

    [Column("BranchUID")]
    public Guid BranchUid { get; set; }

    [Column("DivisionUID")]
    public Guid DivisionUid { get; set; }

    [Column("FYear")]
    public int Fyear { get; set; }

    [Column("ItemUID")]
    public Guid ItemUid { get; set; }

    [Column("FMonth")]
    public DateOnly Fmonth { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal FirstQty { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal SecondQty { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal ApprovedQty { get; set; }

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
