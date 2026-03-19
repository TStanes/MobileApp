using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Keyless]
public partial class VwTaxDetail
{
    [Column("TaxUID")]
    public Guid TaxUid { get; set; }

    [Column("DivisionUID")]
    public Guid DivisionUid { get; set; }

    [Column("ItemGroupUID")]
    public Guid ItemGroupUid { get; set; }

    [Column("StateUID")]
    public Guid StateUid { get; set; }

    [Column("ItemSubGroupUID")]
    public Guid? ItemSubGroupUid { get; set; }

    [Column("ItemUID")]
    public Guid? ItemUid { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? Remarks { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime EffectiveFrom { get; set; }

    public bool FirstSales { get; set; }

    [Column("TaxDetailsUID")]
    public Guid? TaxDetailsUid { get; set; }

    [Column("TaxTypeUID")]
    public Guid TaxTypeUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string TaxTypeCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string TaxTypeDesc { get; set; } = null!;

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? TaxPercentage { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ReportDesc { get; set; }

    [Column("TaxHLevel")]
    public int TaxHlevel { get; set; }
}
