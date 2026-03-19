using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
public partial class IndexUsageInfo
{
    [StringLength(8)]
    [Unicode(false)]
    public string Database { get; set; } = null!;

    [StringLength(128)]
    public string TableName { get; set; } = null!;

    [StringLength(128)]
    public string IndexName { get; set; } = null!;

    [Column("type_desc")]
    [StringLength(60)]
    public string? TypeDesc { get; set; }

    [StringLength(128)]
    public string? ColumnName { get; set; }

    [Column("user_seeks")]
    public long UserSeeks { get; set; }

    [Column("user_scans")]
    public long UserScans { get; set; }

    [Column("user_lookups")]
    public long UserLookups { get; set; }

    [Column("user_updates")]
    public long UserUpdates { get; set; }

    [Column("IndexUsage ")]
    public long? IndexUsage { get; set; }
}
