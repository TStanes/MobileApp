using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("SupplierDeliveryMode")]
public partial class SupplierDeliveryMode
{
    [Column("DeliveryModeUID")]
    public Guid? DeliveryModeUid { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? DeliveryModeDesc { get; set; }
}
