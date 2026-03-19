using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("PurchaseMode")]
public partial class PurchaseMode
{
    [Column("PurchaseModeUID")]
    public Guid PurchaseModeUid { get; set; }

    public int PurchaseModeSlNo { get; set; }

    [StringLength(10)]
    public string PurchaseModeCode { get; set; } = null!;

    [StringLength(50)]
    public string PurchaseModeDesc { get; set; } = null!;

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
