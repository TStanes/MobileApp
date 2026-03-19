using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("BDStatus")]
public partial class Bdstatus
{
    [Key]
    [Column("BDStatusUID")]
    public Guid BdstatusUid { get; set; }

    [Column("VoucherHeaderUID")]
    public Guid VoucherHeaderUid { get; set; }

    [Column("IsBDCollected")]
    public bool IsBdcollected { get; set; }

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
