using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("ProformaInvoiceDetail")]
public partial class ProformaInvoiceDetail
{
    [Key]
    [Column("ProformaInvoiceDetailUID")]
    public Guid ProformaInvoiceDetailUid { get; set; }

    [Column("ProformaInvoiceHeaderUID")]
    public Guid ProformaInvoiceHeaderUid { get; set; }

    [Column("ItemUID")]
    public Guid ItemUid { get; set; }

    [StringLength(100)]
    public string? ContainerNo { get; set; }

    [StringLength(50)]
    public string? KindOfPkgs { get; set; }

    [StringLength(200)]
    public string? GoodsDesc { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Qty { get; set; }

    [StringLength(100)]
    public string? PrintQty { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal Rate { get; set; }

    [StringLength(100)]
    public string? PrintRate { get; set; }

    [Column("CurrencyUID")]
    public Guid CurrencyUid { get; set; }

    [Column(TypeName = "decimal(18, 4)")]
    public decimal Amount { get; set; }

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

    [StringLength(150)]
    [Unicode(false)]
    public string? Remarks { get; set; }

    [Column(TypeName = "decimal(6, 2)")]
    public decimal? LineNumber { get; set; }

    [ForeignKey("CurrencyUid")]
    [InverseProperty("ProformaInvoiceDetails")]
    public virtual CurrencyM CurrencyU { get; set; } = null!;

    [ForeignKey("ItemUid")]
    [InverseProperty("ProformaInvoiceDetails")]
    public virtual ItemM ItemU { get; set; } = null!;

    [ForeignKey("ProformaInvoiceHeaderUid")]
    [InverseProperty("ProformaInvoiceDetails")]
    public virtual ProformaInvoiceHeader ProformaInvoiceHeaderU { get; set; } = null!;
}
