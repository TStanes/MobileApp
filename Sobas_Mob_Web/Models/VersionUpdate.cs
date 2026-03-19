using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Keyless]
[Table("VersionUpdate")]
public partial class VersionUpdate
{
    [StringLength(50)]
    public string? Version { get; set; }

    public bool? IsActive { get; set; }

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

    [Column(TypeName = "datetime")]
    public DateTime? VersionDate { get; set; }
}
