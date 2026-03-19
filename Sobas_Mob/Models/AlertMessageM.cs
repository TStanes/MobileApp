using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("AlertMessageM")]
public partial class AlertMessageM
{
    [Key]
    [Column("AlertMessageUID")]
    public Guid AlertMessageUid { get; set; }

    [Column("MonthEndStatusUID")]
    public Guid MonthEndStatusUid { get; set; }

    public bool IsProcessed { get; set; }

    [StringLength(500)]
    public string Subject { get; set; } = null!;

    [Column(TypeName = "text")]
    public string Message { get; set; } = null!;

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
