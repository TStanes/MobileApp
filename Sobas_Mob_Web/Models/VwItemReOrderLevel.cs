using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Keyless]
public partial class VwItemReOrderLevel
{
    [Column("DivisionUID")]
    public Guid? DivisionUid { get; set; }

    [Column("BranchUID")]
    public Guid? BranchUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? BranchCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? BranchName { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? StateCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? StateDesc { get; set; }

    [Column("ItemUID")]
    public Guid? ItemUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ItemCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? ItemDesc { get; set; }

    [Column("ItemCategoryUID")]
    public Guid? ItemCategoryUid { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ItemCategoryCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? ItemCategoryDesc { get; set; }

    [Column("ItemSegmentUID")]
    public Guid? ItemSegmentUid { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ItemSegmentCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? ItemSegmentDesc { get; set; }

    [Column("ItemGroupUID")]
    public Guid? ItemGroupUid { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? ItemGroupCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? ItemGroupDesc { get; set; }

    [Column("ItemSubGroupUID")]
    public Guid? ItemSubGroupUid { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? ItemSubGroupCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? ItemSubGroupDesc { get; set; }

    [Column("ROL", TypeName = "decimal(10, 2)")]
    public decimal? Rol { get; set; }

    [Column("ROQ", TypeName = "decimal(10, 2)")]
    public decimal? Roq { get; set; }

    [Column("EOQ", TypeName = "decimal(10, 2)")]
    public decimal? Eoq { get; set; }
}
