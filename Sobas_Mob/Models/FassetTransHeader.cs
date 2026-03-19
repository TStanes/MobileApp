using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("FAssetTransHeader")]
public partial class FassetTransHeader
{
    [Key]
    [Column("FAssetTransHeaderUID")]
    public Guid FassetTransHeaderUid { get; set; }

    [Column("FAssetTransNo")]
    [StringLength(50)]
    public string FassetTransNo { get; set; } = null!;

    [Column("FAssetTransDate", TypeName = "datetime")]
    public DateTime FassetTransDate { get; set; }

    [StringLength(50)]
    public string TransactionType { get; set; } = null!;

    [Column("SupplierUID")]
    public Guid SupplierUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string SupplierInvoiceNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime SupplierInvoiceDate { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? CarrierNo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CarrierName { get; set; }

    [Column("LRNO")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Lrno { get; set; }

    [Column("LRDate", TypeName = "datetime")]
    public DateTime? Lrdate { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal ProductValue { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal? Discount { get; set; }

    [Column("SGST", TypeName = "decimal(18, 5)")]
    public decimal? Sgst { get; set; }

    [Column("CGST", TypeName = "decimal(18, 5)")]
    public decimal? Cgst { get; set; }

    [Column("IGST", TypeName = "decimal(18, 5)")]
    public decimal? Igst { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal? OtherExpenseAmount { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal GrossAmount { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal Roundoff { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal NetAmount { get; set; }

    [StringLength(500)]
    public string Remarks { get; set; } = null!;

    [Column(TypeName = "decimal(18, 5)")]
    public decimal BillAmount { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal DiffAmount { get; set; }

    [Column("TCSAmt", TypeName = "decimal(18, 5)")]
    public decimal? Tcsamt { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Reason { get; set; }

    [Column("RefVoucherHeaderUID")]
    public Guid? RefVoucherHeaderUid { get; set; }

    [Column("RefDebitNoteUID")]
    public Guid? RefDebitNoteUid { get; set; }

    public bool VoucherGeneratedFlg { get; set; }

    [Column("StatusUID")]
    public Guid StatusUid { get; set; }

    [Column("StatusID")]
    [StringLength(50)]
    public string StatusId { get; set; } = null!;

    public bool IsPostingApplicable { get; set; }

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

    [InverseProperty("FassetTransHeaderU")]
    public virtual ICollection<FassetTransDetail> FassetTransDetails { get; set; } = new List<FassetTransDetail>();
}
