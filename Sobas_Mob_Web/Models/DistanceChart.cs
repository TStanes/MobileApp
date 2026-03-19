using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("DistanceChart")]
public partial class DistanceChart
{
    [Key]
    [Column("DistanceChartUID")]
    public Guid DistanceChartUid { get; set; }

    [Column("FromBranchUID")]
    public Guid FromBranchUid { get; set; }

    [Column("ToBranchUID")]
    public Guid ToBranchUid { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Distance { get; set; }

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
