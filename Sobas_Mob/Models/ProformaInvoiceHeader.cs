using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("ProformaInvoiceHeader")]
public partial class ProformaInvoiceHeader
{
    [Key]
    [Column("ProformaInvoiceHeaderUID")]
    public Guid ProformaInvoiceHeaderUid { get; set; }

    [Column("BranchUID")]
    public Guid BranchUid { get; set; }

    [Column("DivisionUID")]
    public Guid DivisionUid { get; set; }

    [Column("PartyUID")]
    public Guid? PartyUid { get; set; }

    [Column("EnquiryPartyUID")]
    public Guid? EnquiryPartyUid { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string DocNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime DocDate { get; set; }

    [StringLength(50)]
    public string? CarriageBy { get; set; }

    [StringLength(50)]
    public string? ReceiptByPreCarrier { get; set; }

    [StringLength(50)]
    public string? VesselNo { get; set; }

    [StringLength(50)]
    public string? PortOfLoad { get; set; }

    [StringLength(50)]
    public string? PortOfDischarge { get; set; }

    [StringLength(50)]
    public string? FinalDestination { get; set; }

    [StringLength(50)]
    public string? OtherRef { get; set; }

    [StringLength(50)]
    public string? ExporterRef { get; set; }

    [StringLength(50)]
    public string? BuyerOrderNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? BuyerOrderDate { get; set; }

    [StringLength(50)]
    public string? Buyer { get; set; }

    [StringLength(50)]
    public string? OrginCountry { get; set; }

    [StringLength(50)]
    public string? DestinationCountry { get; set; }

    [StringLength(50)]
    public string? Terms { get; set; }

    [Column(TypeName = "text")]
    public string? Declaration1 { get; set; }

    [Column(TypeName = "text")]
    public string? Declaration2 { get; set; }

    public bool IsActive { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string CreatedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime CreatedDate { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string ModifiedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ModifiedDate { get; set; }

    [Column("RefProformaInvoiceHeaderUID")]
    public Guid? RefProformaInvoiceHeaderUid { get; set; }

    [Column("TransactionTypeUID")]
    public Guid? TransactionTypeUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? InvoiceNo { get; set; }

    public bool? IsCancelled { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? SeeFrieght { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Insurance { get; set; }

    [ForeignKey("BranchUid")]
    [InverseProperty("ProformaInvoiceHeaders")]
    public virtual BranchM BranchU { get; set; } = null!;

    [ForeignKey("DivisionUid")]
    [InverseProperty("ProformaInvoiceHeaders")]
    public virtual DivisionM DivisionU { get; set; } = null!;

    [ForeignKey("EnquiryPartyUid")]
    [InverseProperty("ProformaInvoiceHeaders")]
    public virtual EnquiryM? EnquiryPartyU { get; set; }

    [ForeignKey("PartyUid")]
    [InverseProperty("ProformaInvoiceHeaders")]
    public virtual PartyM? PartyU { get; set; }

    [InverseProperty("ProformaInvoiceHeaderU")]
    public virtual ICollection<ProformaInvoiceDetail> ProformaInvoiceDetails { get; set; } = new List<ProformaInvoiceDetail>();
}
