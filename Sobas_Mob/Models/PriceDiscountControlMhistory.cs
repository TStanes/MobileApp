using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("PriceDiscountControlMHistory")]
public partial class PriceDiscountControlMhistory
{
    [Column("PriceDiscountControlUID")]
    public Guid PriceDiscountControlUid { get; set; }

    [Column("BranchUID")]
    public Guid BranchUid { get; set; }

    [Column("DivisionUID")]
    public Guid DivisionUid { get; set; }

    public bool? IsCashEditable { get; set; }

    public bool? IsCreditEditable { get; set; }

    [Column("IsMRPEditable")]
    public bool? IsMrpeditable { get; set; }

    public bool? IsDiscount1Editable { get; set; }

    public bool? IsDiscount2Editable { get; set; }

    public bool? IsDiscount3Editable { get; set; }

    public bool? IsDiscount4Editable { get; set; }

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
