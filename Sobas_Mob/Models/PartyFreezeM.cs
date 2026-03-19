using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("PartyFreezeM")]
public partial class PartyFreezeM
{
    [Key]
    [Column("PartyIsFreezeUID")]
    public Guid PartyIsFreezeUid { get; set; }

    [Column("PartyUID")]
    public Guid PartyUid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime IsFreezeDate { get; set; }

    public bool IsFreeze { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? Remarks { get; set; }

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
}
