using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("ApprovedVoucherDetailExtn")]
public partial class ApprovedVoucherDetailExtn
{
    [Key]
    [Column("ApprovedVoucherDetailUID")]
    public Guid ApprovedVoucherDetailUid { get; set; }

    [Column("ApprovedVoucherHeaderUID")]
    public Guid ApprovedVoucherHeaderUid { get; set; }

    [Column("LRNO")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Lrno { get; set; }

    [Column("LRDate", TypeName = "datetime")]
    public DateTime? Lrdate { get; set; }

    [Column("LnDivisionUID")]
    public Guid? LnDivisionUid { get; set; }

    [Column("LnDepartmentUID")]
    public Guid? LnDepartmentUid { get; set; }

    [Column("OriginalAccountUID")]
    public Guid? OriginalAccountUid { get; set; }

    [Column("InventoryTransListUID", TypeName = "decimal(18, 0)")]
    public decimal? InventoryTransListUid { get; set; }

    public bool IsActive { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string CreatedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime CreatedDate { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string ModifiedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ModifiedDate { get; set; }

    [Column("RefClaimVoucherUID")]
    public Guid? RefClaimVoucherUid { get; set; }
}
