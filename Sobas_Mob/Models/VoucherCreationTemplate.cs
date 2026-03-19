using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("VoucherCreationTemplate")]
public partial class VoucherCreationTemplate
{
    [Column("VoucherCreationTemplateUID")]
    public Guid VoucherCreationTemplateUid { get; set; }

    [Column("AccountUID")]
    public Guid AccountUid { get; set; }

    [Column("BranchUID")]
    public Guid BranchUid { get; set; }

    [Column("DivisionUID")]
    public Guid? DivisionUid { get; set; }

    [Column("InstantUID")]
    public Guid InstantUid { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal ActualDebit { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal ActualCredit { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string Remarks { get; set; } = null!;

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
}
