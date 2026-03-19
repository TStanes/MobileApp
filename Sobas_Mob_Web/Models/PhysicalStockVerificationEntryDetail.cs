using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("PhysicalStockVerificationEntryDetail")]
public partial class PhysicalStockVerificationEntryDetail
{
    [Key]
    [Column("PhysicalStockVerificationEntryDetailUID")]
    public Guid PhysicalStockVerificationEntryDetailUid { get; set; }

    [Column("PhysicalStockVerificationEntryHeaderUID")]
    public Guid PhysicalStockVerificationEntryHeaderUid { get; set; }

    [Column("ItemUID")]
    public Guid ItemUid { get; set; }

    [Column("ActualStatusUID")]
    public Guid ActualStatusUid { get; set; }

    [Column("SystemStatusUID")]
    public Guid SystemStatusUid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Month { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Year { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Batchno { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Qty { get; set; }

    [Column("MRP", TypeName = "decimal(18, 3)")]
    public decimal Mrp { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Rate { get; set; }

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

    [StringLength(50)]
    [Unicode(false)]
    public string? SystemBatchNo { get; set; }
}
