using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
public partial class VwPodetail
{
    [Column("POLineUID", TypeName = "decimal(18, 0)")]
    public decimal PolineUid { get; set; }

    [Column("POHeaderUID", TypeName = "decimal(18, 0)")]
    public decimal PoheaderUid { get; set; }

    [Column("PONo")]
    [StringLength(20)]
    [Unicode(false)]
    public string Pono { get; set; } = null!;

    [Column("PODate", TypeName = "datetime")]
    public DateTime Podate { get; set; }

    [Column("POIndentUID", TypeName = "decimal(18, 0)")]
    public decimal PoindentUid { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string IndentNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? IndentDate { get; set; }

    [Column("ItemUID")]
    public Guid ItemUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ItemCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string ItemDesc { get; set; } = null!;

    [Column("RequestedBranchUID")]
    public Guid RequestedBranchUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string BranchCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string BranchName { get; set; } = null!;

    [Column("BAddress1")]
    [StringLength(150)]
    [Unicode(false)]
    public string Baddress1 { get; set; } = null!;

    [Column("BAddress2")]
    [StringLength(150)]
    [Unicode(false)]
    public string Baddress2 { get; set; } = null!;

    [Column("BAddress3")]
    [StringLength(150)]
    [Unicode(false)]
    public string Baddress3 { get; set; } = null!;

    [Column("BAddress4")]
    [StringLength(150)]
    [Unicode(false)]
    public string Baddress4 { get; set; } = null!;

    [Column("BCity")]
    [StringLength(50)]
    [Unicode(false)]
    public string Bcity { get; set; } = null!;

    [Column("BCST")]
    [StringLength(50)]
    [Unicode(false)]
    public string Bcst { get; set; } = null!;

    [Column("BTNGST")]
    [StringLength(20)]
    [Unicode(false)]
    public string Btngst { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string BranchStateDesc { get; set; } = null!;

    [Column(TypeName = "decimal(18, 3)")]
    public decimal OrderQty { get; set; }

    [Column("PORate", TypeName = "decimal(18, 3)")]
    public decimal Porate { get; set; }

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

    [Column("SGSTPer", TypeName = "decimal(18, 3)")]
    public decimal Sgstper { get; set; }

    [Column("SGST", TypeName = "decimal(18, 3)")]
    public decimal Sgst { get; set; }

    [Column("CGSTPer", TypeName = "decimal(18, 3)")]
    public decimal Cgstper { get; set; }

    [Column("CGST", TypeName = "decimal(18, 3)")]
    public decimal Cgst { get; set; }

    [Column("IGSTPer", TypeName = "decimal(18, 3)")]
    public decimal Igstper { get; set; }

    [Column("IGST", TypeName = "decimal(18, 3)")]
    public decimal Igst { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? Attribute2 { get; set; }
}
