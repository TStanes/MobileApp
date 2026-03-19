using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("ConsignmentGRNStatus")]
public partial class ConsignmentGrnstatus
{
    [Key]
    [Column("ConsignmentGRNStatusUID")]
    public Guid ConsignmentGrnstatusUid { get; set; }

    [Column("InventoryTransUID", TypeName = "decimal(18, 0)")]
    public decimal InventoryTransUid { get; set; }
}
