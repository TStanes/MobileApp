using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Keyless]
[Table("M_ItemRateHeader_DtChange")]
public partial class MItemRateHeaderDtChange
{
    [Column("ItemRateHeaderUID")]
    public Guid ItemRateHeaderUid { get; set; }

    [Column("ItemRateTypeUID")]
    public Guid ItemRateTypeUid { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string ItemRateDesc { get; set; } = null!;

    [Column("DivisionUID")]
    public Guid? DivisionUid { get; set; }

    [Column("BatchMFGFrom", TypeName = "datetime")]
    public DateTime BatchMfgfrom { get; set; }

    [Column("BatchMFGTo", TypeName = "datetime")]
    public DateTime BatchMfgto { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime FromDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ToDate { get; set; }

    [Column("ParentItemRateHeaderUID")]
    public Guid? ParentItemRateHeaderUid { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? PercentagePlus { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? PercentageMinus { get; set; }

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
