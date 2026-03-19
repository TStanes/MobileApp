using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("SupVoucherMatch")]
public partial class SupVoucherMatch
{
    [Key]
    [Column("SupVoucherMatchUID")]
    public Guid SupVoucherMatchUid { get; set; }

    [Column("BillPassingUID")]
    public Guid BillPassingUid { get; set; }

    [Column("DrVoucherUID")]
    public Guid DrVoucherUid { get; set; }

    [Column("CrVoucherUID")]
    public Guid CrVoucherUid { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal AdjustedAmount { get; set; }

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
}
