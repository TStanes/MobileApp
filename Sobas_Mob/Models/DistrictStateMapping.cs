using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("DistrictStateMapping")]
public partial class DistrictStateMapping
{
    [StringLength(50)]
    [Unicode(false)]
    public string? StateCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? StateDesc { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? District { get; set; }

    public double? IsActive { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Modifiedby { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDate { get; set; }
}
