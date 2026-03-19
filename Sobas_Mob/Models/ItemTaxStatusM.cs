using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("ItemTaxStatusM")]
public partial class ItemTaxStatusM
{
    [Key]
    [Column("ItemTaxStatusUID")]
    public Guid ItemTaxStatusUid { get; set; }

    [Column("ItemUID")]
    public Guid ItemUid { get; set; }

    public bool? IsTax { get; set; }

    public bool? IsPrice { get; set; }

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
