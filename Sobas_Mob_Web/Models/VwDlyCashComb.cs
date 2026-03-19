using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Keyless]
public partial class VwDlyCashComb
{
    [Column("Branch_Code")]
    [StringLength(50)]
    [Unicode(false)]
    public string BranchCode { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? InvoiceNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InvDate { get; set; }

    [Column("Invoice_Ident")]
    [StringLength(150)]
    [Unicode(false)]
    public string InvoiceIdent { get; set; } = null!;

    [Column("opb")]
    public int Opb { get; set; }

    [Column("DR", TypeName = "decimal(18, 3)")]
    public decimal Dr { get; set; }

    [Column("CR", TypeName = "decimal(18, 3)")]
    public decimal Cr { get; set; }

    [Column("STA")]
    [StringLength(1)]
    [Unicode(false)]
    public string Sta { get; set; } = null!;
}
