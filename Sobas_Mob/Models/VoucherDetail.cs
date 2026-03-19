using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("VoucherDetail")]
[Index("VoucherDetailUid", "CreatedDate", "VoucherHeaderUid", Name = "_dta_index_VoucherDetail_7_1927677915__K1_K16_K2")]
[Index("VoucherHeaderUid", "IsActive", "VoucherDetailUid", "AccountUid", "BranchUid", Name = "_dta_index_VoucherDetail_7_1927677915__K2_K14_K1_K5_K6_7_11_12")]
[Index("VoucherHeaderUid", "AccountUid", "DebitAmt", "IsActive", "CreditAmt", Name = "_dta_index_VoucherDetail_7_1927677915__K2_K5_K11_K14_K12")]
[Index("AccountUid", "CreditAmt", "VoucherHeaderUid", Name = "_dta_index_VoucherDetail_7_1927677915__K5_K12_K2")]
public partial class VoucherDetail
{
    [Key]
    [Column("VoucherDetailUID")]
    public Guid VoucherDetailUid { get; set; }

    [Column("VoucherHeaderUID")]
    public Guid VoucherHeaderUid { get; set; }

    public int TransId { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal LineNumber { get; set; }

    [Column("AccountUID")]
    public Guid AccountUid { get; set; }

    [Column("BranchUID")]
    public Guid? BranchUid { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string Details { get; set; } = null!;

    [Column("ItemSegmentUID")]
    public Guid? ItemSegmentUid { get; set; }

    [Column("ItemGroupUID")]
    public Guid? ItemGroupUid { get; set; }

    [Column("ItemSubGroupUID")]
    public Guid? ItemSubGroupUid { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal DebitAmt { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal CreditAmt { get; set; }

    [Column("VechicleUID")]
    public Guid? VechicleUid { get; set; }

    public bool IsActive { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string CreatedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime CreatedDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ModifiedDate { get; set; }

    [ForeignKey("AccountUid")]
    [InverseProperty("VoucherDetails")]
    public virtual AccountM AccountU { get; set; } = null!;

    [ForeignKey("VoucherHeaderUid")]
    [InverseProperty("VoucherDetails")]
    public virtual VoucherHeader VoucherHeaderU { get; set; } = null!;
}
