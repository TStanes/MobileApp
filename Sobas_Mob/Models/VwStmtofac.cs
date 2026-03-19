using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
public partial class VwStmtofac
{
    [StringLength(20)]
    [Unicode(false)]
    public string? VoucherNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DocDate { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string PartyId { get; set; } = null!;

    [Column("Ref_Voucher_No")]
    [StringLength(20)]
    [Unicode(false)]
    public string? RefVoucherNo { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Status { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Debit { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Credit { get; set; }

    [StringLength(201)]
    [Unicode(false)]
    public string? Details { get; set; }

    public bool Deleted { get; set; }

    [Column("Branch_Code")]
    [StringLength(50)]
    [Unicode(false)]
    public string? BranchCode { get; set; }

    [Column("PARTYNAM")]
    [StringLength(150)]
    [Unicode(false)]
    public string Partynam { get; set; } = null!;

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

    [Column("Reference_no")]
    [StringLength(20)]
    [Unicode(false)]
    public string? ReferenceNo { get; set; }

    [Column("Reference_date", TypeName = "datetime")]
    public DateTime ReferenceDate { get; set; }

    [Column("novadata")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Novadata { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? AreaDesc { get; set; }
}
