using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("StockPointCommisionInventoryLink")]
public partial class StockPointCommisionInventoryLink
{
    [Key]
    [Column("SPCLinkUID")]
    public Guid SpclinkUid { get; set; }

    [Column("StcokPointCommisionUID")]
    public Guid StcokPointCommisionUid { get; set; }

    [Column("InventorytransListUID", TypeName = "decimal(18, 0)")]
    public decimal InventorytransListUid { get; set; }

    [Column("ApprovedVoucherHeaderUID")]
    public Guid ApprovedVoucherHeaderUid { get; set; }

    public bool Isactive { get; set; }

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
