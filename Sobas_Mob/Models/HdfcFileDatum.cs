using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("HDFC_File_Data")]
public partial class HdfcFileDatum
{
    [StringLength(255)]
    public string? F1 { get; set; }

    [StringLength(255)]
    public string? BeneficiaryCode { get; set; }

    [StringLength(255)]
    public string? BeneName { get; set; }

    [Column("IFSC")]
    [StringLength(255)]
    public string? Ifsc { get; set; }

    [StringLength(255)]
    public string? BeneBankName { get; set; }

    [StringLength(255)]
    public string? BranchName { get; set; }

    [StringLength(255)]
    public string? CreditAccount { get; set; }

    [StringLength(255)]
    public string? F8 { get; set; }

    [StringLength(255)]
    public string? F9 { get; set; }

    [StringLength(255)]
    public string? F10 { get; set; }

    [StringLength(255)]
    public string? F11 { get; set; }

    [StringLength(255)]
    public string? F12 { get; set; }

    [StringLength(255)]
    public string? F13 { get; set; }

    [StringLength(255)]
    public string? F14 { get; set; }

    [StringLength(255)]
    public string? F15 { get; set; }

    [StringLength(255)]
    public string? F16 { get; set; }

    [StringLength(255)]
    public string? F17 { get; set; }

    [StringLength(255)]
    public string? F18 { get; set; }

    [StringLength(255)]
    public string? F19 { get; set; }

    [StringLength(255)]
    public string? F20 { get; set; }

    [StringLength(255)]
    public string? F21 { get; set; }
}
