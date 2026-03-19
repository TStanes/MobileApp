using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("PayModeM")]
public partial class PayModeM
{
    [Key]
    [Column("ModeUID", TypeName = "decimal(18, 0)")]
    public decimal ModeUid { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string ModeDesc { get; set; } = null!;

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

    [InverseProperty("PayModeU")]
    public virtual ICollection<VoucherHeader> VoucherHeaders { get; set; } = new List<VoucherHeader>();
}
