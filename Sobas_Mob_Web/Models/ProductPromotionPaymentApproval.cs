using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("ProductPromotionPaymentApproval")]
public partial class ProductPromotionPaymentApproval
{
    [Key]
    [Column("PPApprovalUID")]
    public Guid PpapprovalUid { get; set; }

    [Column("PPApprovalNo")]
    [StringLength(50)]
    public string PpapprovalNo { get; set; } = null!;

    [Column("PPRequestUID")]
    public Guid PprequestUid { get; set; }

    [Column("ReqEmpUID")]
    public Guid ReqEmpUid { get; set; }

    [Column("FieldEmpID")]
    [StringLength(150)]
    public string FieldEmpId { get; set; } = null!;

    [Column("AppBranchUID")]
    public Guid AppBranchUid { get; set; }

    [Column("AppDivisionUID")]
    public Guid AppDivisionUid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime AppFromDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime AppToDate { get; set; }

    public int AppMonth { get; set; }

    public int AppYear { get; set; }

    public int AppStatus { get; set; }

    public int PaymentStatus { get; set; }

    [StringLength(500)]
    public string RejectReason { get; set; } = null!;

    [Column(TypeName = "decimal(18, 2)")]
    public decimal RetainerFee { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Batta { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal FoodExp { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal VehicleReimb { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal CompaighExp { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal PrintingExp { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal OtherExp { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Total { get; set; }

    [StringLength(500)]
    public string? Remarks { get; set; }

    [StringLength(10)]
    public string? IsActive { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDate { get; set; }
}
