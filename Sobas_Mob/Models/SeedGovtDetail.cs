using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("SeedGovtDetail")]
public partial class SeedGovtDetail
{
    [Key]
    [Column("SeedGovtDetailUID")]
    public Guid SeedGovtDetailUid { get; set; }

    [Column("ReceiptInventoryTransUID", TypeName = "decimal(18, 0)")]
    public decimal ReceiptInventoryTransUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? GovtLotNo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? GovtTestNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? GovtTestDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? GovtCertificateDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExpiryDate { get; set; }

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

    [ForeignKey("ReceiptInventoryTransUid")]
    [InverseProperty("SeedGovtDetails")]
    public virtual InventoryTran ReceiptInventoryTransU { get; set; } = null!;
}
