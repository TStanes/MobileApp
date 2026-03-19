using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
public partial class MdclassificationM
{
    [Column("ItemSubGroupUID")]
    public Guid ItemSubGroupUid { get; set; }

    [Column("MDClasification")]
    [StringLength(255)]
    public string Mdclasification { get; set; } = null!;

    [StringLength(255)]
    public string ItemSubGroupCode { get; set; } = null!;

    [StringLength(255)]
    public string ItemSubGroupDesc { get; set; } = null!;
}
