using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("BDlistHistory")]
public partial class BdlistHistory
{
    [StringLength(10)]
    [Unicode(false)]
    public string PartyCode { get; set; } = null!;

    [StringLength(255)]
    public string? Name { get; set; }

    [Column("DivisionPrincipleUID")]
    public Guid DivisionPrincipleUid { get; set; }

    [StringLength(255)]
    public string? Div { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDate { get; set; }

    [Column("BDYear")]
    [StringLength(10)]
    public string? Bdyear { get; set; }
}
