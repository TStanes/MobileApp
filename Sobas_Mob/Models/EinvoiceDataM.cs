using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("EinvoiceDataM")]
public partial class EinvoiceDataM
{
    [Column("IrnEinvoiceBhDataUID")]
    public Guid IrnEinvoiceBhDataUid { get; set; }

    [Key]
    [Column("InventoryTransUID", TypeName = "decimal(18, 0)")]
    public decimal InventoryTransUid { get; set; }

    [Column("document_status")]
    [StringLength(50)]
    public string? DocumentStatus { get; set; }

    [Column("error_response")]
    [StringLength(500)]
    public string? ErrorResponse { get; set; }

    [Column("errors")]
    [StringLength(500)]
    public string? Errors { get; set; }

    [StringLength(500)]
    public string? ErrorDetails { get; set; }

    [StringLength(10)]
    public string? Success { get; set; }

    [StringLength(50)]
    public string? AckNo { get; set; }

    [StringLength(50)]
    public string? AckDt { get; set; }

    [StringLength(200)]
    public string? Irn { get; set; }

    public string? SignedInvoice { get; set; }

    [Column("SignedQRCode")]
    public string? SignedQrcode { get; set; }

    [StringLength(50)]
    public string? Status { get; set; }

    [Column("transaction_id")]
    [StringLength(100)]
    public string? TransactionId { get; set; }

    public string? InvoicedData { get; set; }

    [Column("Inv_CancelReqStatus")]
    [StringLength(200)]
    public string? InvCancelReqStatus { get; set; }

    [Column("Inv_CancelStatus")]
    [StringLength(200)]
    public string? InvCancelStatus { get; set; }

    [Column("Inv_CancelDate")]
    [StringLength(50)]
    public string? InvCancelDate { get; set; }

    [Column("Inv_Cancelreason")]
    [StringLength(500)]
    public string? InvCancelreason { get; set; }

    [StringLength(1000)]
    public string? Remarks { get; set; }

    [StringLength(200)]
    public string? Att1 { get; set; }

    [StringLength(200)]
    public string? Att2 { get; set; }

    [StringLength(1000)]
    public string? Att3 { get; set; }

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
