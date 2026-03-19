using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("BDList")]
public partial class Bdlist
{
    [Key]
    [Column("BDListUID")]
    public Guid BdlistUid { get; set; }

    [Column("PartyUID")]
    public Guid PartyUid { get; set; }

    [Column("DivisionPrincipleUID")]
    public Guid DivisionPrincipleUid { get; set; }

    [Column("BDYear")]
    [StringLength(9)]
    [Unicode(false)]
    public string Bdyear { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime EffectFrom { get; set; }

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

    [ForeignKey("DivisionPrincipleUid")]
    [InverseProperty("Bdlists")]
    public virtual DivisionPrincipleM DivisionPrincipleU { get; set; } = null!;

    [ForeignKey("PartyUid")]
    [InverseProperty("Bdlists")]
    public virtual PartyM PartyU { get; set; } = null!;
}
