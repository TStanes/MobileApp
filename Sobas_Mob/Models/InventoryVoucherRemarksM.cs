using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("InventoryVoucherRemarksM")]
public partial class InventoryVoucherRemarksM
{
    [Key]
    [Column("RowUID")]
    public Guid RowUid { get; set; }

    public int? Slno { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string HeaderDescription { get; set; } = null!;

    [StringLength(2000)]
    [Unicode(false)]
    public string Remarks { get; set; } = null!;

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
