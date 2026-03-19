using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("SyncDBList")]
public partial class SyncDblist
{
    [Key]
    [Column("SyncDBListUID")]
    public int SyncDblistUid { get; set; }

    [Column("SyncDBName")]
    [StringLength(50)]
    [Unicode(false)]
    public string SyncDbname { get; set; } = null!;

    public bool IsActive { get; set; }
}
