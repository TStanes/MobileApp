using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Keyless]
[Table("BranchConnectionM")]
public partial class BranchConnectionM
{
    [Column("BranchUID")]
    public Guid BranchUid { get; set; }

    [StringLength(50)]
    public string BranchCode { get; set; } = null!;

    [StringLength(200)]
    public string? BranchName { get; set; }

    [StringLength(200)]
    public string? HostName { get; set; }

    [StringLength(500)]
    public string? ConnectionString { get; set; }

    public bool IsActive { get; set; }

    public bool? IsConnected { get; set; }
}
