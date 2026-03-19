using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("PhysicalStockVerificationDetail")]
public partial class PhysicalStockVerificationDetail
{
    [Key]
    [Column("PhysicalStockVerificationDetailUID")]
    public Guid PhysicalStockVerificationDetailUid { get; set; }

    [Column("PhysicalStockVerificationHeaderUID")]
    public Guid PhysicalStockVerificationHeaderUid { get; set; }

    [Column("ItemUID")]
    public Guid ItemUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? BatchNo { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal BookQty { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? GoodQty { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? DamagedQty { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? LeakageQty { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Reason { get; set; }

    public bool IsActive { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string CreatedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime CreatedDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDate { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? ExpiredQty { get; set; }

    [ForeignKey("PhysicalStockVerificationHeaderUid")]
    [InverseProperty("PhysicalStockVerificationDetails")]
    public virtual PhysicalStockVerificationHeader PhysicalStockVerificationHeaderU { get; set; } = null!;
}
