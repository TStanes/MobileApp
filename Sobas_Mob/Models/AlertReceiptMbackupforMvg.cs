using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("AlertReceiptMBackupforMVG")]
public partial class AlertReceiptMbackupforMvg
{
    [Column("AlertReceiptUID")]
    public Guid AlertReceiptUid { get; set; }

    [Column("MonthEndStatusUID")]
    public Guid MonthEndStatusUid { get; set; }

    public bool IsProcessed { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string Type { get; set; } = null!;

    [Column("EmailID")]
    [StringLength(100)]
    public string EmailId { get; set; } = null!;

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
