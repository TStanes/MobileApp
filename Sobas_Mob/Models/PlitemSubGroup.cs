using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("PLItemSubGroup")]
public partial class PlitemSubGroup
{
    [StringLength(255)]
    public string? ItemSubGroupCode { get; set; }

    [StringLength(255)]
    public string? ItemSubGroupDesc { get; set; }

    [Column("CLASSIFICATION")]
    [StringLength(255)]
    public string? Classification { get; set; }

    [Column("ClassificationUID")]
    [StringLength(255)]
    public string? ClassificationUid { get; set; }

    [Column("PLClassificationItemSubGroupMappingUID")]
    [StringLength(255)]
    public string? PlclassificationItemSubGroupMappingUid { get; set; }
}
