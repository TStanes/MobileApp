using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("SalesOfficerHierachyChildM")]
public partial class SalesOfficerHierachyChildM
{
    public Guid? Parent { get; set; }

    [Column("descendant")]
    public Guid? Descendant { get; set; }

    [Column("lvl")]
    public bool? Lvl { get; set; }

    [StringLength(50)]
    public string? Parentsocode { get; set; }

    [StringLength(50)]
    public string? ParentSoName { get; set; }

    [StringLength(50)]
    public string? ParentEmpCode { get; set; }

    [StringLength(50)]
    public string? SoCode { get; set; }

    [StringLength(50)]
    public string? SoName { get; set; }

    [StringLength(50)]
    public string? SoEmpCode { get; set; }

    public bool? ParentIsactive { get; set; }

    public bool? SoIsactive { get; set; }

    public DateOnly? RunDate { get; set; }
}
