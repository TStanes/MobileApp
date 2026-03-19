using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Keyless]
public partial class VwItemRate
{
    [Column("ItemRateHeaderUID")]
    public Guid ItemRateHeaderUid { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string ItemRateDesc { get; set; } = null!;

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

    [Column(TypeName = "decimal(18, 5)")]
    public decimal? Rate { get; set; }
}
