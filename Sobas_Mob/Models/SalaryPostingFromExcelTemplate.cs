using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("SalaryPostingFromExcelTemplate")]
public partial class SalaryPostingFromExcelTemplate
{
    [StringLength(255)]
    public string? AccountCode { get; set; }

    public double? DebitAmt { get; set; }

    public double? CreditAmt { get; set; }

    [StringLength(255)]
    public string? DivisionCode { get; set; }

    [StringLength(255)]
    public string? BranchCode { get; set; }

    public DateOnly? VoucherDate { get; set; }
}
