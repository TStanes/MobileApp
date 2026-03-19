using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("SyncTableList")]
public partial class SyncTableList
{
    [Key]
    public int SlNo { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string TableName { get; set; } = null!;

    public int GroupNo { get; set; }

    public int OrderNo { get; set; }

    public bool IsActive { get; set; }
}
