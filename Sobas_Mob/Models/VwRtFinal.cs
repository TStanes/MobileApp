using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
public partial class VwRtFinal
{
    [Column("VoucherHeaderUID")]
    public Guid VoucherHeaderUid { get; set; }

    [Column("status")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Status { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? SoName { get; set; }

    [Column("PARTYNAM")]
    [StringLength(150)]
    [Unicode(false)]
    public string Partynam { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string Address1 { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string Address2 { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string Address3 { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string Address4 { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string City { get; set; } = null!;

    [Column("BRNAM")]
    [StringLength(150)]
    [Unicode(false)]
    public string Brnam { get; set; } = null!;

    [Column("BRAD1")]
    [StringLength(150)]
    [Unicode(false)]
    public string Brad1 { get; set; } = null!;

    [Column("BRAD2")]
    [StringLength(150)]
    [Unicode(false)]
    public string Brad2 { get; set; } = null!;

    [Column("BRAD3")]
    [StringLength(150)]
    [Unicode(false)]
    public string Brad3 { get; set; } = null!;

    [Column("BRAD4")]
    [StringLength(150)]
    [Unicode(false)]
    public string Brad4 { get; set; } = null!;

    [Column("BRCTY")]
    [StringLength(50)]
    [Unicode(false)]
    public string Brcty { get; set; } = null!;

    [Column(TypeName = "decimal(18, 3)")]
    public decimal CreditAmt { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PartyId { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? PcrNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PcrDate { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string Caption { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string? InPaymentOf { get; set; }

    [Column("Cheque_Date", TypeName = "datetime")]
    public DateTime? ChequeDate { get; set; }

    [Column("Cheque_No")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ChequeNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DocDate { get; set; }

    [Column("Ref_Voucher_No")]
    [StringLength(20)]
    [Unicode(false)]
    public string? RefVoucherNo { get; set; }

    [Column("PTYCOD")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Ptycod { get; set; }

    [Column("mdesc")]
    [StringLength(25)]
    [Unicode(false)]
    public string? Mdesc { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? Idesc { get; set; }

    [Column("Branch_Code")]
    [StringLength(50)]
    [Unicode(false)]
    public string? BranchCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? PartyName { get; set; }

    [Column("PTYAD1")]
    [StringLength(150)]
    [Unicode(false)]
    public string? Ptyad1 { get; set; }

    [Column("PTYAD2")]
    [StringLength(150)]
    [Unicode(false)]
    public string? Ptyad2 { get; set; }

    [Column("PTYAD3")]
    [StringLength(150)]
    [Unicode(false)]
    public string? Ptyad3 { get; set; }

    [Column("PTYAD4")]
    [StringLength(150)]
    [Unicode(false)]
    public string? Ptyad4 { get; set; }

    [Column("PTYCTY")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Ptycty { get; set; }

    public bool? Deleted { get; set; }

    [Column("hdrdet")]
    [StringLength(150)]
    [Unicode(false)]
    public string? Hdrdet { get; set; }

    [Column("BranchUID")]
    public Guid? BranchUid { get; set; }

    [Column("DivisionUID")]
    public Guid? DivisionUid { get; set; }

    [Column("TransactiontypesUID")]
    public Guid TransactiontypesUid { get; set; }
}
