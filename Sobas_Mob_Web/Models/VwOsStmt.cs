using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Keyless]
public partial class VwOsStmt
{
    [StringLength(50)]
    [Unicode(false)]
    public string? BranchCode { get; set; }

    [Column("BRNAM")]
    [StringLength(150)]
    [Unicode(false)]
    public string? Brnam { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? PartyId { get; set; }

    [Column("PARTYNAM")]
    [StringLength(150)]
    [Unicode(false)]
    public string? Partynam { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string Status { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string InvoiceNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime InvDate { get; set; }

    [Column(TypeName = "decimal(38, 3)")]
    public decimal? Amount { get; set; }

    [Column(TypeName = "decimal(38, 3)")]
    public decimal? AdjAmt { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DueDate { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string SoName { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string Seg { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string Istat { get; set; } = null!;

    [Column("grpnam")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Grpnam { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string Address1 { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string? Address2 { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? Address3 { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? Address4 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? City { get; set; }

    [Column("AREA")]
    [StringLength(3)]
    [Unicode(false)]
    public string Area { get; set; } = null!;

    [Column(TypeName = "decimal(12, 4)")]
    public decimal CrLimit { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? Purpose { get; set; }
}
