using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("SchemeCNBranchRequest")]
[Index("DiscountUid", "BranchUid", Name = "IX_SchemeCNBranchRequest_DiscountUID_BranchUID")]
public partial class SchemeCnbranchRequest
{
    [Key]
    [Column("SchemeCNRequestUID")]
    public Guid SchemeCnrequestUid { get; set; }

    [Column("DiscountUID")]
    public Guid DiscountUid { get; set; }

    [Column("BranchUID")]
    public Guid BranchUid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime RequestedDate { get; set; }

    public bool IsProcessed { get; set; }

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
