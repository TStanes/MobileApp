using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("TaxboxMDetails")]
public partial class TaxboxMdetail
{
    [Column("TaxDetailsUID")]
    public Guid? TaxDetailsUid { get; set; }

    [Column("TaxUID")]
    public Guid? TaxUid { get; set; }

    [Column("TaxTypeUID")]
    [StringLength(36)]
    [Unicode(false)]
    public string TaxTypeUid { get; set; } = null!;

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? TaxPercentage { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ReportDesc { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string IsActive { get; set; } = null!;

    [StringLength(12)]
    [Unicode(false)]
    public string CreatedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime CreatedDate { get; set; }

    [StringLength(12)]
    [Unicode(false)]
    public string ModifiedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ModifiedDate { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string LowerRateTaxPercentage { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime RefCreatedDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime RefModifiedDate { get; set; }
}
