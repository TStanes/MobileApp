using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("DDLEvents")]
public partial class Ddlevent
{
    [Column(TypeName = "datetime")]
    public DateTime EventDate { get; set; }

    [StringLength(64)]
    public string? EventType { get; set; }

    [Column("EventDDL")]
    public string? EventDdl { get; set; }

    [Column("EventXML", TypeName = "xml")]
    public string? EventXml { get; set; }

    [StringLength(255)]
    public string? DatabaseName { get; set; }

    [StringLength(255)]
    public string? SchemaName { get; set; }

    [StringLength(255)]
    public string? ObjectName { get; set; }

    [StringLength(64)]
    [Unicode(false)]
    public string? HostName { get; set; }

    [Column("IPAddress")]
    [StringLength(32)]
    [Unicode(false)]
    public string? Ipaddress { get; set; }

    [StringLength(255)]
    public string? ProgramName { get; set; }

    [StringLength(255)]
    public string? LoginName { get; set; }
}
