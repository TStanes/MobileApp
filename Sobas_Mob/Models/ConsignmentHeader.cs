using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("ConsignmentHeader")]
public partial class ConsignmentHeader
{
    [Key]
    [Column("ConsignmentHeaderUID", TypeName = "decimal(18, 0)")]
    public decimal ConsignmentHeaderUid { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string ConsignmentNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ConsignmentDate { get; set; }

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

    [InverseProperty("ConsignmentHeaderU")]
    public virtual ICollection<ConsignmentDetail> ConsignmentDetails { get; set; } = new List<ConsignmentDetail>();

    [ForeignKey("DivisionUid")]
    [InverseProperty("ConsignmentHeaders")]
    public virtual DivisionM DivisionU { get; set; } = null!;

    [ForeignKey("RequestedBranchUid")]
    [InverseProperty("ConsignmentHeaders")]
    public virtual BranchM RequestedBranchU { get; set; } = null!;

    [ForeignKey("SupplierUid")]
    [InverseProperty("ConsignmentHeaders")]
    public virtual PartyM SupplierU { get; set; } = null!;
}
