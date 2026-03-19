using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("FAssetTransDetail")]
[Index("FassetSegmentUid", Name = "<Name of Missing Index, sysname,>")]
public partial class FassetTransDetail
{
    [Key]
    [Column("FAssetTransDetailUID")]
    public Guid FassetTransDetailUid { get; set; }

    [Column("FAssetTransHeaderUID")]
    public Guid FassetTransHeaderUid { get; set; }

    [Column("FAssetSerialNo")]
    [StringLength(50)]
    public string FassetSerialNo { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string Category { get; set; } = null!;

    [Column("BranchUID")]
    public Guid BranchUid { get; set; }

    [Column("DivisionUID")]
    public Guid DivisionUid { get; set; }

    [Column("FAssetSegmentUID")]
    public Guid FassetSegmentUid { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal NetQty { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal Rate { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal GrossAmount { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? DiscountPer { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal? Discount { get; set; }

    [Column("SGSTPer", TypeName = "decimal(18, 3)")]
    public decimal? Sgstper { get; set; }

    [Column("SGST", TypeName = "decimal(18, 5)")]
    public decimal? Sgst { get; set; }

    [Column("CGSTPer", TypeName = "decimal(18, 3)")]
    public decimal? Cgstper { get; set; }

    [Column("CGST", TypeName = "decimal(18, 5)")]
    public decimal? Cgst { get; set; }

    [Column("IGSTPer", TypeName = "decimal(18, 3)")]
    public decimal? Igstper { get; set; }

    [Column("IGST", TypeName = "decimal(18, 5)")]
    public decimal? Igst { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal? OtherExpense { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal NetAmount { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal CostValue { get; set; }

    [Column("StatusID")]
    [StringLength(50)]
    public string StatusId { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string? Make { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Model { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? RefNo { get; set; }

    [Column("PONo")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Pono { get; set; }

    [Column("PODate", TypeName = "datetime")]
    public DateTime? Podate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PutIntoUseDate { get; set; }

    [Column("FAssestApprovalDate", TypeName = "datetime")]
    public DateTime? FassestApprovalDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? InstallationDate { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? Remarks { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? OtherRemarks { get; set; }

    public bool IsPostingApplicable { get; set; }

    [Column("RefAssestUID")]
    public Guid? RefAssestUid { get; set; }

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

    [ForeignKey("FassetSegmentUid")]
    [InverseProperty("FassetTransDetails")]
    public virtual FassetSegmentM FassetSegmentU { get; set; } = null!;

    [InverseProperty("FassetTransDetailU")]
    public virtual FassetTransDetailExtn? FassetTransDetailExtn { get; set; }

    [ForeignKey("FassetTransHeaderUid")]
    [InverseProperty("FassetTransDetails")]
    public virtual FassetTransHeader FassetTransHeaderU { get; set; } = null!;
}
