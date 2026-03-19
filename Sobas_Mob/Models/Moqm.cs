using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("MOQM")]
public partial class Moqm
{
    [Key]
    [Column("MOQUID")]
    public Guid Moquid { get; set; }

    [Column("ItemUID")]
    public Guid ItemUid { get; set; }

    [Column("BranchUID")]
    public Guid BranchUid { get; set; }

    [Column("MOQ", TypeName = "decimal(18, 5)")]
    public decimal Moq { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? LeadTime { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? GracePeriod { get; set; }

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
