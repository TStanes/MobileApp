using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Keyless]
[Table("VOUCHERMATCHLINK_BK")]
public partial class VouchermatchlinkBk
{
    [Column("VoucherMatchLinkUID")]
    public Guid VoucherMatchLinkUid { get; set; }

    [Column("VoucherMatchDRUID")]
    public Guid VoucherMatchDruid { get; set; }

    [Column("VoucherMatchCRUID")]
    public Guid VoucherMatchCruid { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal AdjAmt { get; set; }

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
