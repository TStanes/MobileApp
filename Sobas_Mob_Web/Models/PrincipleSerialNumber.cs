using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("PrincipleSerialNumber")]
public partial class PrincipleSerialNumber
{
    [Key]
    [Column("PrincipleSerialNumberUID")]
    public Guid PrincipleSerialNumberUid { get; set; }

    [Column("DivisionUID")]
    public Guid DivisionUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string PrincipleSerialNoCode { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string PrincipleSerialNoName { get; set; } = null!;

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
    public DateTime? ModifiedDate { get; set; }

    [ForeignKey("DivisionUid")]
    [InverseProperty("PrincipleSerialNumbers")]
    public virtual DivisionM DivisionU { get; set; } = null!;

    [InverseProperty("PrincipleSerialNumberU")]
    public virtual ICollection<ItemPrincipleSerialNoLink> ItemPrincipleSerialNoLinks { get; set; } = new List<ItemPrincipleSerialNoLink>();
}
