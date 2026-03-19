using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[PrimaryKey("TableName", "PartyUid")]
public partial class ChangeFlag
{
    [Key]
    [Column("PartyUID")]
    public Guid PartyUid { get; set; }

    [Key]
    [StringLength(128)]
    public string TableName { get; set; } = null!;

    [Column("ChangeFlag")]
    public bool? ChangeFlag1 { get; set; }
}
