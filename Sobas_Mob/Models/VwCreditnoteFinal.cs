using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
public partial class VwCreditnoteFinal
{
    [Column("VoucherHeaderUID")]
    public Guid VoucherHeaderUid { get; set; }

    [Column("Ref_Voucher_No")]
    [StringLength(20)]
    [Unicode(false)]
    public string? RefVoucherNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DocDate { get; set; }

    [Column("DBPARTY")]
    [StringLength(50)]
    [Unicode(false)]
    public string Dbparty { get; set; } = null!;

    [Column("PCRNo")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Pcrno { get; set; }

    [Column("PCRDate", TypeName = "datetime")]
    public DateTime? Pcrdate { get; set; }

    [Column("BRNAM")]
    [StringLength(150)]
    [Unicode(false)]
    public string? Brnam { get; set; }

    [Column("glname")]
    [StringLength(150)]
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

    [StringLength(150)]
    [Unicode(false)]
    public string? Status { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Debit { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Credit { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? InPaymentOf { get; set; }

    [Column("Debit_Branch")]
    [StringLength(50)]
    [Unicode(false)]
    public string? DebitBranch { get; set; }

    [Column("division_code")]
    [StringLength(10)]
    [Unicode(false)]
    public string DivisionCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string? Details { get; set; }

    [Column("BRAD1")]
    [StringLength(150)]
    [Unicode(false)]
    public string? Brad1 { get; set; }

    [Column("BRAD2")]
    [StringLength(150)]
    [Unicode(false)]
    public string? Brad2 { get; set; }

    [Column("BRAD3")]
    [StringLength(150)]
    [Unicode(false)]
    public string? Brad3 { get; set; }

    [Column("BRAD4")]
    [StringLength(150)]
    [Unicode(false)]
    public string? Brad4 { get; set; }

    [Column("BRCTY")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Brcty { get; set; }

    public bool? Deleted { get; set; }

    [Column("Branch_Code")]
    [StringLength(50)]
    [Unicode(false)]
    public string? BranchCode { get; set; }

    [Column("CRPARTY")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Crparty { get; set; }

    [Column("DBPTYDESC")]
    [StringLength(800)]
    [Unicode(false)]
    public string Dbptydesc { get; set; } = null!;

    [Column("BranchUID")]
    public Guid? BranchUid { get; set; }

    [Column("DivisionUID")]
    public Guid? DivisionUid { get; set; }

    [Column("TransactiontypesUID")]
    public Guid TransactiontypesUid { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string TransactionTypeCode { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? RequestNumber { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RequestDate { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal LineNumber { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string CreatedBy { get; set; } = null!;

    [Column(TypeName = "decimal(18, 3)")]
    public decimal PartyAmt { get; set; }
}
