using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("VoucherMatchLink")]
public partial class VoucherMatchLink
{
    [Key]
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

    [ForeignKey("VoucherMatchCruid")]
    [InverseProperty("VoucherMatchLinkVoucherMatchCrus")]
    public virtual VoucherMatch VoucherMatchCru { get; set; } = null!;

    [ForeignKey("VoucherMatchDruid")]
    [InverseProperty("VoucherMatchLinkVoucherMatchDrus")]
    public virtual VoucherMatch VoucherMatchDru { get; set; } = null!;
}
