using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("AreaSOItemGroup")]
[Index("IsActive", Name = "IX_Isactive")]
public partial class AreaSoitemGroup
{
    [Key]
    [Column("AreaSOItemGroupUID")]
    public Guid AreaSoitemGroupUid { get; set; }

    [Column("DivisionPrincipleUID")]
    public Guid DivisionPrincipleUid { get; set; }

    [Column("AreaSOUID")]
    public Guid AreaSouid { get; set; }

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

    [Column(TypeName = "datetime")]
    public DateTime? EffectiveFromDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EffectiveToDate { get; set; }

    [ForeignKey("AreaSouid")]
    [InverseProperty("AreaSoitemGroups")]
    public virtual AreaSomapping AreaSou { get; set; } = null!;

    [ForeignKey("DivisionPrincipleUid")]
    [InverseProperty("AreaSoitemGroups")]
    public virtual DivisionPrincipleM DivisionPrincipleU { get; set; } = null!;
}
