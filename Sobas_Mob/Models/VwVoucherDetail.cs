using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
public partial class VwVoucherDetail
{
    [Column("VoucherDetailUID")]
    public Guid VoucherDetailUid { get; set; }

    [Column("VoucherHeaderUID")]
    public Guid VoucherHeaderUid { get; set; }

    public int TransId { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal LineNumber { get; set; }

    [Column("AccountUID")]
    public Guid AccountUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? AccountCode { get; set; }

    [StringLength(800)]
    [Unicode(false)]
    public string? AccountDescription { get; set; }

    public Guid? PartyUid { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? PartyCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? PartyName { get; set; }

    [Column("BranchUID")]
    public Guid? BranchUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? BranchCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? BranchName { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string Details { get; set; } = null!;

    [Column("ItemSegmentUID")]
    public Guid? ItemSegmentUid { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ItemSegmentCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? ItemSegmentDesc { get; set; }

    [Column("ItemGroupUID")]
    public Guid? ItemGroupUid { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? ItemGroupCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? ItemGroupDesc { get; set; }

    [Column("ItemSubGroupUID")]
    public Guid? ItemSubGroupUid { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? ItemSubGroupCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? ItemSubGroupDesc { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal DebitAmt { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal CreditAmt { get; set; }

    [Column("VechicleUID")]
    public Guid? VechicleUid { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? VechicleNo { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? VechicleType { get; set; }

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
}
