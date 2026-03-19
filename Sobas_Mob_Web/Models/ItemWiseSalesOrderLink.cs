using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("ItemWiseSalesOrderLink")]
public partial class ItemWiseSalesOrderLink
{
    [Key]
    [Column("ItemWiseSalesOrderLinkUID")]
    public Guid ItemWiseSalesOrderLinkUid { get; set; }

    [Column("InventoryTransListUID", TypeName = "decimal(18, 0)")]
    public decimal InventoryTransListUid { get; set; }

    [Column("SalesOrderDetailUID")]
    public Guid SalesOrderDetailUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string BatchNo { get; set; } = null!;

    [Column(TypeName = "decimal(18, 5)")]
    public decimal Qty { get; set; }

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
