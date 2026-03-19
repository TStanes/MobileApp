using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("BranchPOtoReceive")]
public partial class BranchPotoReceive
{
    [Key]
    [Column("BranchPOReceiptUID")]
    public Guid BranchPoreceiptUid { get; set; }

    [Column("ReceivingBranchUID")]
    public Guid ReceivingBranchUid { get; set; }

    [Column("DivisionUID")]
    public Guid DivisionUid { get; set; }

    [Column("POLineUID", TypeName = "decimal(18, 0)")]
    public decimal PolineUid { get; set; }

    [Column("PONo")]
    [StringLength(20)]
    [Unicode(false)]
    public string Pono { get; set; } = null!;

    [Column("PODate", TypeName = "datetime")]
    public DateTime Podate { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string IndentNo { get; set; } = null!;

    [Column("ItemUID")]
    public Guid ItemUid { get; set; }

    [Column("SupplierUID")]
    public Guid SupplierUid { get; set; }

    [Column(TypeName = "decimal(12, 3)")]
    public decimal OrderQty { get; set; }

    [Column(TypeName = "decimal(12, 3)")]
    public decimal? ReceivedQty { get; set; }

    [Column("PORate", TypeName = "decimal(12, 3)")]
    public decimal? Porate { get; set; }

    [Column(TypeName = "decimal(12, 3)")]
    public decimal? Discount1 { get; set; }

    [Column(TypeName = "decimal(12, 3)")]
    public decimal? Discount2 { get; set; }

    [Column(TypeName = "decimal(12, 3)")]
    public decimal? Discount3 { get; set; }

    [Column(TypeName = "decimal(12, 3)")]
    public decimal? Discount4 { get; set; }

    [Column("ED", TypeName = "decimal(12, 3)")]
    public decimal? Ed { get; set; }

    [Column("EDCess", TypeName = "decimal(12, 3)")]
    public decimal? Edcess { get; set; }

    [Column("VAT", TypeName = "decimal(12, 3)")]
    public decimal? Vat { get; set; }

    [Column("VATCess", TypeName = "decimal(12, 3)")]
    public decimal? Vatcess { get; set; }

    [Column(TypeName = "decimal(12, 3)")]
    public decimal? SecondaryCess { get; set; }

    [Column("StatusUID")]
    public Guid? StatusUid { get; set; }

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

    [Column("SGST", TypeName = "decimal(18, 3)")]
    public decimal Sgst { get; set; }

    [Column("CGST", TypeName = "decimal(18, 3)")]
    public decimal Cgst { get; set; }

    [Column("IGST", TypeName = "decimal(18, 3)")]
    public decimal Igst { get; set; }
}
