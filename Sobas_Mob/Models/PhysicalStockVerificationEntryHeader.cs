using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("PhysicalStockVerificationEntryHeader")]
public partial class PhysicalStockVerificationEntryHeader
{
    [Key]
    [Column("PhysicalStockVerificationEntryHeaderUID")]
    public Guid PhysicalStockVerificationEntryHeaderUid { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string PhysicalStockVerificationDesc { get; set; } = null!;

    [Column("DivisionUID")]
    public Guid DivisionUid { get; set; }

    [Column("BranchUID")]
    public Guid BranchUid { get; set; }

    [Column("SVDate", TypeName = "datetime")]
    public DateTime Svdate { get; set; }

    public bool Locked { get; set; }

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
}
