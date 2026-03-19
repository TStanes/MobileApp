using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
public partial class TableCommDetail
{
    [Unicode(false)]
    public string? TableName { get; set; }

    [StringLength(50)]
    public string? FilterType { get; set; }

    [StringLength(5)]
    public string? TableType { get; set; }

    [StringLength(5)]
    public string? CommType { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? TableStatus { get; set; }

    [Column("UIDStatus")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Uidstatus { get; set; }
}
