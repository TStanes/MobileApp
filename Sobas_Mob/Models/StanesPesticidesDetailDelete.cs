using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("StanesPesticidesDetail_Delete")]
public partial class StanesPesticidesDetailDelete
{
    [Column("StanesPesticidesDetailUID")]
    public Guid? StanesPesticidesDetailUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ItemCode { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? GroupName { get; set; }
}
