using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("GSTExpDetails")]
public partial class GstexpDetail
{
    [Key]
    [Column("GSTExpDetailsUID")]
    public Guid GstexpDetailsUid { get; set; }

    [Column("BranchUID")]
    public Guid BranchUid { get; set; }

    [Column("GSTExpSlNo")]
    [StringLength(20)]
    public string GstexpSlNo { get; set; } = null!;

    [Column("VoucherHeaderUID")]
    public Guid VoucherHeaderUid { get; set; }

    [Column("VoucherDetailUID")]
    public Guid VoucherDetailUid { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string DocumentType { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string TransactionType { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string SupplierName { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string City { get; set; } = null!;

    [Column("StateUID")]
    public Guid StateUid { get; set; }

    [Column("GSTNo")]
    [StringLength(50)]
    [Unicode(false)]
    public string Gstno { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string DocNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime DocDate { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal AmtBeforeTax { get; set; }

    [Column("SGSTPer", TypeName = "decimal(18, 2)")]
    public decimal Sgstper { get; set; }

    [Column("SGSTAmt", TypeName = "decimal(18, 3)")]
    public decimal Sgstamt { get; set; }

    [Column("CGSTPer", TypeName = "decimal(18, 2)")]
    public decimal Cgstper { get; set; }

    [Column("CGSTAmt", TypeName = "decimal(18, 3)")]
    public decimal Cgstamt { get; set; }

    [Column("IGSTPer", TypeName = "decimal(18, 2)")]
    public decimal Igstper { get; set; }

    [Column("IGSTAmt", TypeName = "decimal(18, 3)")]
    public decimal Igstamt { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal AmtAfterTax { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal OtherAmtPlus { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal OtherAmtMinus { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal RoundOff { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal NetVal { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? Remarks { get; set; }

    [Column("TABillUID")]
    public Guid TabillUid { get; set; }

    [Column("StatusUID")]
    public Guid StatusUid { get; set; }

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
}
