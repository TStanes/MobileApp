using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
public partial class VwControlCodeM
{
    [Column("AccountUID")]
    public Guid AccountUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string AccountCode { get; set; } = null!;

    [StringLength(800)]
    [Unicode(false)]
    public string AccountDescription { get; set; } = null!;

    [StringLength(800)]
    [Unicode(false)]
    public string PrintDescription { get; set; } = null!;

    public int AccountType { get; set; }

    public bool IsGroup { get; set; }

    public bool? IsDivision { get; set; }

    [StringLength(10)]
    public string? IsBranch { get; set; }

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
