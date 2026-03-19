using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("POHeader")]
[Index("DivisionUid", Name = "IX_POHeader_DivisionUID_Includes")]
[Index("PoheaderUid", "SupplierUid", "RequestedBranchUid", "DivisionUid", "StatusUid", Name = "_dta_index_POHeader_7_391672443__K1_K6_K5_K4_K27")]
public partial class Poheader
{
    [Key]
    [Column("POHeaderUID", TypeName = "decimal(18, 0)")]
    public decimal PoheaderUid { get; set; }

    [Column("PONo")]
    [StringLength(20)]
    [Unicode(false)]
    public string Pono { get; set; } = null!;

    [Column("PODate", TypeName = "datetime")]
    public DateTime Podate { get; set; }

    [Column("DivisionUID")]
    public Guid DivisionUid { get; set; }

    [Column("RequestedBranchUID")]
    public Guid RequestedBranchUid { get; set; }

    [Column("SupplierUID")]
    public Guid SupplierUid { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string RefNo { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string InvPacking { get; set; } = null!;

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Insurance { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Freight { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Others { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal TotalAmount { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string PaymentTerms { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string Carrier { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string DeliveryType { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string Remarks { get; set; } = null!;

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Discount1 { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Discount2 { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Discount3 { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Discount4 { get; set; }

    [Column("ED", TypeName = "decimal(18, 3)")]
    public decimal Ed { get; set; }

    [Column("EDCess", TypeName = "decimal(18, 3)")]
    public decimal Edcess { get; set; }

    [Column("VAT", TypeName = "decimal(18, 3)")]
    public decimal Vat { get; set; }

    [Column("VATCess", TypeName = "decimal(18, 3)")]
    public decimal Vatcess { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal SecondaryCess { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal NetAmount { get; set; }

    [Column("StatusUID")]
    public Guid StatusUid { get; set; }

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

    [Column("SGST", TypeName = "decimal(18, 3)")]
    public decimal Sgst { get; set; }

    [Column("CGST", TypeName = "decimal(18, 3)")]
    public decimal Cgst { get; set; }

    [Column("IGST", TypeName = "decimal(18, 3)")]
    public decimal Igst { get; set; }

    [ForeignKey("DivisionUid")]
    [InverseProperty("Poheaders")]
    public virtual DivisionM DivisionU { get; set; } = null!;

    [InverseProperty("PoheaderU")]
    public virtual ICollection<Podetail> Podetails { get; set; } = new List<Podetail>();

    [ForeignKey("RequestedBranchUid")]
    [InverseProperty("Poheaders")]
    public virtual BranchM RequestedBranchU { get; set; } = null!;

    [ForeignKey("SupplierUid")]
    [InverseProperty("Poheaders")]
    public virtual PartyM SupplierU { get; set; } = null!;
}
