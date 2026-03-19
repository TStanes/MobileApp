using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Keyless]
[Table("VersionM_History")]
public partial class VersionMHistory
{
    [Column("VersionMHistoryUID")]
    public Guid? VersionMhistoryUid { get; set; }

    [Column("VersionID")]
    public int VersionId { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime VersionDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Versions { get; set; } = null!;

    public int? IsScriptUpdate { get; set; }

    public bool? IsActive { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDate { get; set; }

    [Column("BranchUID")]
    public Guid? BranchUid { get; set; }
}
