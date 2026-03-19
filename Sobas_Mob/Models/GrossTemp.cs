using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("Gross_Temp")]
public partial class GrossTemp
{
    [Column("AccountUID")]
    [StringLength(255)]
    public string? AccountUid { get; set; }

    [StringLength(255)]
    public string? AccountCode { get; set; }

    [StringLength(255)]
    public string? AccountDescription { get; set; }

    [Column("Item Sub GroupCode ")]
    [StringLength(255)]
    public string? ItemSubGroupCode { get; set; }

    [Column("Item Sub Group Description")]
    [StringLength(255)]
    public string? ItemSubGroupDescription { get; set; }

    [Column("Item Sub Group UID")]
    [StringLength(255)]
    public string? ItemSubGroupUid { get; set; }
}
