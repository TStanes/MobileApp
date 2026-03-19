using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("ProductPromotionPaymentRequestM")]
public partial class ProductPromotionPaymentRequestM
{
    [Key]
    [Column("PPRequestUID")]
    public Guid PprequestUid { get; set; }

    [Column("PPRequestNo")]
    [StringLength(150)]
    public string PprequestNo { get; set; } = null!;

    [Column("ReqEmpUID")]
    public Guid ReqEmpUid { get; set; }

    [Column("FieldEmpID")]
    [StringLength(150)]
    public string FieldEmpId { get; set; } = null!;

    [Column("ReqBranchUID")]
    public Guid ReqBranchUid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ReqFromDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ReqToDate { get; set; }

    public int ReqMonth { get; set; }

    public int ReqYear { get; set; }

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
