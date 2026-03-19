using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("ConsignmentDetail")]
public partial class ConsignmentDetail
{
    [Key]
    [Column("ConsignmentLineUID", TypeName = "decimal(18, 0)")]
    public decimal ConsignmentLineUid { get; set; }

    [Column("ConsignmentHeaderUID", TypeName = "decimal(18, 0)")]
    public decimal ConsignmentHeaderUid { get; set; }

    [StringLength(50)]
    public string BatchNo { get; set; } = null!;

    [Column("ItemUID")]
    public Guid ItemUid { get; set; }

    [Column("RequestedBranchUID")]
    public Guid RequestedBranchUid { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal OrderQty { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal ConsignmentRate { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal ProductValue { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal GrossAmount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal ReceivedQty { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Discount1Per { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Discount1 { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Discount2Per { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Discount2 { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Discount3Per { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Discount3 { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal DiscountPer { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Discount4 { get; set; }

    [Column("EDPer", TypeName = "decimal(18, 3)")]
    public decimal Edper { get; set; }

    [Column("ED", TypeName = "decimal(18, 3)")]
    public decimal Ed { get; set; }

    [Column("EDCessPer", TypeName = "decimal(18, 3)")]
    public decimal EdcessPer { get; set; }

    [Column("EDCess", TypeName = "decimal(18, 3)")]
    public decimal Edcess { get; set; }

    [Column("VATPer", TypeName = "decimal(18, 3)")]
    public decimal Vatper { get; set; }

    [Column("VAT", TypeName = "decimal(18, 3)")]
    public decimal Vat { get; set; }

    [Column("VATCessPer", TypeName = "decimal(18, 3)")]
    public decimal VatcessPer { get; set; }

    [Column("VATCess", TypeName = "decimal(18, 3)")]
    public decimal Vatcess { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal SecondaryCessPer { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal SecondaryCess { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal NetAmount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal CostValue { get; set; }

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

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? AmendMinusQty { get; set; }

    [ForeignKey("ConsignmentHeaderUid")]
    [InverseProperty("ConsignmentDetails")]
    public virtual ConsignmentHeader ConsignmentHeaderU { get; set; } = null!;

    [ForeignKey("ItemUid")]
    [InverseProperty("ConsignmentDetails")]
    public virtual ItemM ItemU { get; set; } = null!;
}
