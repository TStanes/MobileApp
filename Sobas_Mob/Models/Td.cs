using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("tds")]
public partial class Td
{
    [Column("ITSectionUID")]
    public double? ItsectionUid { get; set; }

    [Column("ITSectionCode")]
    [StringLength(255)]
    public string? ItsectionCode { get; set; }

    [Column("ITSectionDesc")]
    [StringLength(255)]
    public string? ItsectionDesc { get; set; }

    [StringLength(255)]
    public string? PrintDescription { get; set; }

    [Column("TDSPer")]
    public double? Tdsper { get; set; }

    [Column("TDSGlCodeUID")]
    [StringLength(255)]
    public string? TdsglCodeUid { get; set; }
}
