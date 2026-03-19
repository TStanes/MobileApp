using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("ProductionQRCodeList")]
public partial class ProductionQrcodeList
{
    [Key]
    [Column("InventoryTransUID", TypeName = "decimal(18, 0)")]
    public decimal InventoryTransUid { get; set; }

    [Column("BranchUID")]
    public Guid BranchUid { get; set; }

    [StringLength(500)]
    public string RegistrationNo { get; set; } = null!;

    [StringLength(50)]
    public string BatchNo { get; set; } = null!;

    [Column(TypeName = "decimal(18, 5)")]
    public decimal NetQty { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime MfgDt { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ExpDt { get; set; }

    [Column("MRP", TypeName = "decimal(18, 3)")]
    public decimal Mrp { get; set; }

    [Column("USP", TypeName = "decimal(18, 3)")]
    public decimal Usp { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string ManufacturedBy { get; set; } = null!;

    [StringLength(500)]
    [Unicode(false)]
    public string MarketedBy { get; set; } = null!;

    [StringLength(50)]
    public string Email { get; set; } = null!;

    [StringLength(50)]
    public string ContactNo { get; set; } = null!;

    [Column("IsPDFGenerated")]
    public bool IsPdfgenerated { get; set; }

    public bool IsActive { get; set; }

    [StringLength(10)]
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
