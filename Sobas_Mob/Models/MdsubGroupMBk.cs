using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("MDSubGroupM_BK")]
public partial class MdsubGroupMBk
{
    [StringLength(255)]
    public string? ItemSegmentCode { get; set; }

    [StringLength(255)]
    public string? ItemSegmentDesc { get; set; }

    [StringLength(255)]
    public string? ItemGroupCode { get; set; }

    [StringLength(255)]
    public string? ItemGroupDesc { get; set; }

    [StringLength(255)]
    public string? ItemSubGroupCode { get; set; }

    [Column("MDClasification")]
    [StringLength(255)]
    public string? Mdclasification { get; set; }

    [StringLength(255)]
    public string? Classify { get; set; }

    [StringLength(255)]
    public string? ItemSubGroupDesc { get; set; }

    public short? DispOrder { get; set; }
}
