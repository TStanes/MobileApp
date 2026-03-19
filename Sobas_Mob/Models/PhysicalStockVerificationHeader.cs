using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("PhysicalStockVerificationHeader")]
public partial class PhysicalStockVerificationHeader
{
    [Key]
    [Column("PhysicalStockVerificationHeaderUID")]
    public Guid PhysicalStockVerificationHeaderUid { get; set; }

    [Column("BranchUID")]
    public Guid BranchUid { get; set; }

    [Column("DivisionUID")]
    public Guid DivisionUid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime AsOnDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? VerificationDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? VerifiedBy { get; set; }

    public bool IsGenerateAutoAdj { get; set; }

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

    [Column("PhysicalStockVerificationEntryHeaderUID")]
    public Guid? PhysicalStockVerificationEntryHeaderUid { get; set; }

    [InverseProperty("PhysicalStockVerificationHeaderU")]
    public virtual ICollection<PhysicalStockVerificationDetail> PhysicalStockVerificationDetails { get; set; } = new List<PhysicalStockVerificationDetail>();
}
