using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("DailyCheckedList")]
public partial class DailyCheckedList
{
    [Column("DailychecklistUID")]
    public Guid DailychecklistUid { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string ErrorDesc { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime FromDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ToDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime RunDate { get; set; }

    public int? TotalRecords { get; set; }

    public int? QueryReference { get; set; }

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

    public bool? IsActive { get; set; }
}
