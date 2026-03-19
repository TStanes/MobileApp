using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("TaxMCIpdDetails")]
public partial class TaxMcipdDetail
{
    [Column("newtaxDetailsuid")]
    public Guid? NewtaxDetailsuid { get; set; }

    [Column("taxUid")]
    public Guid TaxUid { get; set; }

    [Column("TaxTypeUID")]
    public Guid TaxTypeUid { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? TaxPercentage { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string ReportDesc { get; set; } = null!;

    public bool IsActive { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string CreatedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime CreatedDate { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string Modifiedby { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ModifiedDate { get; set; }
}
