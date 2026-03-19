using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
public partial class VwPriceMapping
{
    [StringLength(168)]
    [Unicode(false)]
    public string Party { get; set; } = null!;

    [StringLength(163)]
    [Unicode(false)]
    public string Dealer { get; set; } = null!;

    [StringLength(163)]
    [Unicode(false)]
    public string Area { get; set; } = null!;

    [StringLength(203)]
    [Unicode(false)]
    public string Branch { get; set; } = null!;

    [StringLength(203)]
    [Unicode(false)]
    public string State { get; set; } = null!;

    [StringLength(163)]
    [Unicode(false)]
    public string Country { get; set; } = null!;

    [Column("ItemRateHeaderUID")]
    public Guid ItemRateHeaderUid { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string RateTypeCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string RateTypeDesc { get; set; } = null!;

    [Column("BatchMFGFrom", TypeName = "datetime")]
    public DateTime BatchMfgfrom { get; set; }

    [Column("BatchMFGTo", TypeName = "datetime")]
    public DateTime BatchMfgto { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime FromDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ToDate { get; set; }

    [Column("ItemUID")]
    public Guid ItemUid { get; set; }

    [Column(TypeName = "decimal(10, 5)")]
    public decimal Rate { get; set; }

    [Column("PartyUID")]
    public Guid? PartyUid { get; set; }

    [Column("DealerCategoryUID")]
    public Guid? DealerCategoryUid { get; set; }

    [Column("AreaUID")]
    public Guid? AreaUid { get; set; }

    [Column("BranchUID")]
    public Guid? BranchUid { get; set; }

    [Column("StateUID")]
    public Guid? StateUid { get; set; }

    [Column("CountryUID")]
    public Guid? CountryUid { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string ItemRateDesc { get; set; } = null!;

    public int RateMappingOrder { get; set; }
}
