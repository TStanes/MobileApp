using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("PODetail")]
[Index("PoheaderUid", Name = "IX_PODetail_POHeaderUID")]
[Index("PoindentUid", Name = "IX_PODetail_POIndentUID")]
public partial class Podetail
{
    [Key]
    [Column("POLineUID", TypeName = "decimal(18, 0)")]
    public decimal PolineUid { get; set; }

    [Column("POHeaderUID", TypeName = "decimal(18, 0)")]
    public decimal PoheaderUid { get; set; }

    [Column("POIndentUID", TypeName = "decimal(18, 0)")]
    public decimal PoindentUid { get; set; }

    [Column("ItemUID")]
    public Guid ItemUid { get; set; }

    [Column("RequestedBranchUID")]
    public Guid RequestedBranchUid { get; set; }

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

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? AmendMinusQty { get; set; }

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

    [ForeignKey("ItemUid")]
    [InverseProperty("Podetails")]
    public virtual ItemM ItemU { get; set; } = null!;

    [ForeignKey("PoheaderUid")]
    [InverseProperty("Podetails")]
    public virtual Poheader PoheaderU { get; set; } = null!;

    [InverseProperty("PolineU")]
    public virtual ICollection<Poschedule> Poschedules { get; set; } = new List<Poschedule>();
}
