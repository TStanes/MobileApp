using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("TempVoucherCreation")]
public partial class TempVoucherCreation
{
    [Column(TypeName = "decimal(18, 3)")]
    public decimal? ActualDebit { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? ActualCredit { get; set; }

    [StringLength(255)]
    public string? AccountCode { get; set; }

    [StringLength(255)]
    public string? BranchCode { get; set; }

    [StringLength(255)]
    public string? DivisionCode { get; set; }

    [StringLength(255)]
    public string? Remarks { get; set; }
}
