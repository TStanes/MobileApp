using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

public partial class DepositDetail
{
    [Key]
    [Column("DepositDetailUID")]
    public Guid DepositDetailUid { get; set; }

    public int DocumentNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DocumentDate { get; set; }

    [Column("VoucherHeaderUID")]
    public Guid? VoucherHeaderUid { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? PartyCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? PartyName { get; set; }

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

    [StringLength(150)]
    [Unicode(false)]
    public string? City { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? State { get; set; }

    [Column("PANNo")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Panno { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? ReceiptNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ReceiptDate { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? ReceiptAmount { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? RefundRectNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? RefundRectDate { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? RefundAmount { get; set; }

    public bool IsRefreredVoucher { get; set; }

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
