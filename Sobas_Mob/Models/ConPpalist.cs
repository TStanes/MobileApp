using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("ConPPAList")]
public partial class ConPpalist
{
    [Column("Branch Code")]
    [StringLength(3)]
    public string? BranchCode { get; set; }

    [Column("Branch Name")]
    [StringLength(200)]
    public string? BranchName { get; set; }

    [Column("EMP id")]
    public int? EmpId { get; set; }

    [Column("EMP name")]
    [StringLength(200)]
    public string? EmpName { get; set; }

    [Column("PPA Code")]
    [StringLength(20)]
    public string? PpaCode { get; set; }

    [Column("PPA Name")]
    [StringLength(200)]
    public string? PpaName { get; set; }

    [Column("Contact Number")]
    [StringLength(20)]
    public string? ContactNumber { get; set; }

    [StringLength(200)]
    public string? Location { get; set; }
}
