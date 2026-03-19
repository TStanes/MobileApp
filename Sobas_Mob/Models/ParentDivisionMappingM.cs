using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("ParentDivisionMappingM")]
public partial class ParentDivisionMappingM
{
    [Column("ParentDivisionMappingUID")]
    public Guid ParentDivisionMappingUid { get; set; }

    [Column("UnderDivisionUID")]
    public Guid UnderDivisionUid { get; set; }

    [StringLength(50)]
    public string UnderDivision { get; set; } = null!;

    [Column("DivisionUID")]
    public Guid DivisionUid { get; set; }

    [Column("ParentDivisionUID")]
    public Guid ParentDivisionUid { get; set; }

    public string? Remarks { get; set; }

    public string? Status { get; set; }

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
