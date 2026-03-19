using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
public partial class VwpaymentFinal
{
    [Column("Ref_Voucher_No")]
    [StringLength(20)]
    [Unicode(false)]
    public string? RefVoucherNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DocDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PartyId { get; set; }

    [Column("dbparty")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Dbparty { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? PcrNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PcrDate { get; set; }

    [Column("GDesc")]
    [StringLength(150)]
    [Unicode(false)]
    public string? Gdesc { get; set; }

    [Column("glname")]
    [StringLength(800)]
    [Unicode(false)]
    public string? Glname { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? Address1 { get; set; }

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

    [Column("voucity")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Voucity { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string Caption { get; set; } = null!;

    [Column("Analytical_code")]
    [StringLength(4)]
    [Unicode(false)]
    public string? AnalyticalCode { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Status { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Debit { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? InPaymentOf { get; set; }

    [Column("Debit_Branch")]
    [StringLength(150)]
    [Unicode(false)]
    public string? DebitBranch { get; set; }

    [Column("DIVCOD")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Divcod { get; set; }

    [StringLength(800)]
    [Unicode(false)]
    public string? Expr1 { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? Details { get; set; }

    public bool? Deleted { get; set; }

    [Column("Branch_Code")]
    [StringLength(50)]
    [Unicode(false)]
    public string? BranchCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Expr2 { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Segment { get; set; }

    [Column("VoucherHeaderUID")]
    public Guid VoucherHeaderUid { get; set; }

    [Column("DivisionUID")]
    public Guid? DivisionUid { get; set; }

    [Column("BranchUID")]
    public Guid? BranchUid { get; set; }

    [Column("TransactionTypesUID")]
    public Guid TransactionTypesUid { get; set; }
}
