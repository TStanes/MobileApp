using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("salarypostingBackup")]
public partial class SalarypostingBackup
{
    [Column("SalaryPostingUID")]
    public Guid SalaryPostingUid { get; set; }

    public int Month { get; set; }

    [Column("TJ_DATE", TypeName = "datetime")]
    public DateTime TjDate { get; set; }

    [Column("BRANCHCODE")]
    [StringLength(3)]
    [Unicode(false)]
    public string Branchcode { get; set; } = null!;

    [Column("GL_ACCOUNT_CODE")]
    [StringLength(255)]
    [Unicode(false)]
    public string GlAccountCode { get; set; } = null!;

    [Column("newgl")]
    [StringLength(255)]
    [Unicode(false)]
    public string? Newgl { get; set; }

    [Column("oldgl")]
    [StringLength(255)]
    [Unicode(false)]
    public string? Oldgl { get; set; }

    [Column("DEPT")]
    public double? Dept { get; set; }

    [Column("DESCRIPTION")]
    [StringLength(255)]
    [Unicode(false)]
    public string Description { get; set; } = null!;

    [Column("DEBIT", TypeName = "decimal(18, 3)")]
    public decimal Debit { get; set; }

    [Column("CREDIT", TypeName = "decimal(18, 3)")]
    public decimal Credit { get; set; }

    [Column("TJ_TYP")]
    [StringLength(255)]
    [Unicode(false)]
    public string? TjTyp { get; set; }

    [Column("employeeid")]
    [StringLength(255)]
    [Unicode(false)]
    public string Employeeid { get; set; } = null!;

    [Column("TJ_NO")]
    public double TjNo { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string Remarks { get; set; } = null!;

    public bool IsProcessed { get; set; }

    public bool IsActive { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string CreatedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime CreatedDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ModifiedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ModifiedDate { get; set; }

    public Guid DivisionUid { get; set; }
}
