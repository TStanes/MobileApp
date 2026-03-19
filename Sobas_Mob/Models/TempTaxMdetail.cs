using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("TempTaxMDetails")]
public partial class TempTaxMdetail
{
    [Column("TaxDetailsUID")]
    public Guid TaxDetailsUid { get; set; }

    [Column("TaxUID")]
    public Guid TaxUid { get; set; }

    [Column("TaxTypeUID")]
    public Guid TaxTypeUid { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? TaxPercentage { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string ReportDesc { get; set; } = null!;

    public bool IsActive { get; set; }

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

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? LowerRateTaxPercentage { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RefCreatedDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RefModifiedDate { get; set; }
}
