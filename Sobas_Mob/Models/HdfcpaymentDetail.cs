using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("HDFCPaymentDetails")]
public partial class HdfcpaymentDetail
{
    [Key]
    [Column("HDFCPaymentUID")]
    public Guid HdfcpaymentUid { get; set; }

    [Column("VoucherHeaderUID")]
    public Guid? VoucherHeaderUid { get; set; }

    [Column("VoucherDetailUID")]
    public Guid? VoucherDetailUid { get; set; }

    [StringLength(20)]
    public string VoucherNo { get; set; } = null!;

    [StringLength(50)]
    public string? VoucherRefNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime VoucherDate { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal TranAmount { get; set; }

    [StringLength(20)]
    public string PartyCode { get; set; } = null!;

    [StringLength(30)]
    public string? PartyBankAccNo { get; set; }

    [StringLength(150)]
    public string? BankName { get; set; }

    [StringLength(150)]
    public string? BankBranch { get; set; }

    [Column("IFSCCode")]
    [StringLength(20)]
    public string? Ifsccode { get; set; }

    [StringLength(150)]
    public string? PartyName { get; set; }

    [StringLength(150)]
    public string? PartyAddress1 { get; set; }

    [StringLength(150)]
    public string? PaymentDetails { get; set; }

    [StringLength(150)]
    public string? PartyEmail { get; set; }

    [StringLength(50)]
    public string? CustomerRefNo { get; set; }

    [StringLength(20)]
    public string? AccountType { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime PaymentDate { get; set; }

    [StringLength(50)]
    public string? BankRefNo { get; set; }

    [StringLength(50)]
    public string FileRefNo { get; set; } = null!;

    [StringLength(50)]
    public string? RetFileRefNo { get; set; }

    [Column("UTRNo")]
    [StringLength(50)]
    public string? Utrno { get; set; }

    [Column("UTRDate", TypeName = "datetime")]
    public DateTime? Utrdate { get; set; }

    [StringLength(150)]
    public string? Att1 { get; set; }

    [StringLength(150)]
    public string? Att2 { get; set; }

    [StringLength(150)]
    public string? Remarks { get; set; }

    [StringLength(50)]
    public string CreatedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime CreatedDate { get; set; }

    [StringLength(50)]
    public string ModifiedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ModifiedDate { get; set; }
}
