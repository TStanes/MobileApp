using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("EinvIRNNotGenerated")]
public partial class EinvIrnnotGenerated
{
    [StringLength(50)]
    [Unicode(false)]
    public string BranchCode { get; set; } = null!;

    [Column("docno")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Docno { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DocDate { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string TransactionTypeDesc { get; set; } = null!;

    [Column(TypeName = "decimal(18, 3)")]
    public decimal NetVal { get; set; }

    [Column("CGST", TypeName = "decimal(18, 3)")]
    public decimal Cgst { get; set; }

    [Column("SGST", TypeName = "decimal(18, 3)")]
    public decimal Sgst { get; set; }

    [Column("IGST", TypeName = "decimal(18, 3)")]
    public decimal Igst { get; set; }

    [Column("GSTNO")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Gstno { get; set; }

    [Column("document_status")]
    [StringLength(50)]
    public string DocumentStatus { get; set; } = null!;

    [Column("IRN")]
    [StringLength(200)]
    public string Irn { get; set; } = null!;
}
