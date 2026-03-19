using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("Adj")]
public partial class Adj
{
    public double? BranchCode { get; set; }

    [StringLength(255)]
    public string? BranchName { get; set; }

    [Column("cn_purpose")]
    [StringLength(255)]
    public string? CnPurpose { get; set; }

    [Column("DN_Docdate", TypeName = "datetime")]
    public DateTime? DnDocdate { get; set; }

    [Column("CN_DocNo")]
    [StringLength(255)]
    public string? CnDocNo { get; set; }

    [Column("CNDocDate", TypeName = "datetime")]
    public DateTime? CndocDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDate { get; set; }

    public double? Difference { get; set; }

    [Column("DNDif")]
    public double? Dndif { get; set; }

    public double? AdjustDays { get; set; }

    [StringLength(255)]
    public string? Info { get; set; }
}
