using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("IndexMaintenanceHistory")]
public partial class IndexMaintenanceHistory
{
    [Key]
    [Column("IndexCommandID")]
    public int IndexCommandId { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? DatabaseName { get; set; }

    [StringLength(6000)]
    [Unicode(false)]
    public string? IndexCommandString { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DateTimeExecuted { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DateTimeCompleted { get; set; }
}
