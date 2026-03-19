using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("SyncStatus")]
public partial class SyncStatus
{
    [Key]
    [Column("SyncUID")]
    public Guid SyncUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string RunBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime StartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EndDate { get; set; }

    public bool Status { get; set; }

    [StringLength(250)]
    [Unicode(false)]
    public string? Remarks { get; set; }
}
