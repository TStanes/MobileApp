using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
public partial class VwLiftDetailsForSchemeWithType
{
    [Column("BranchUID")]
    public Guid BranchUid { get; set; }

    [Column("DivisionUID")]
    public Guid DivisionUid { get; set; }

    [Column("InventoryTransUID", TypeName = "decimal(18, 0)")]
    public decimal InventoryTransUid { get; set; }

    [Column("InventoryTransListUID", TypeName = "decimal(18, 0)")]
    public decimal InventoryTransListUid { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? DocNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime DocDate { get; set; }

    [Column("PartyUID")]
    public Guid? PartyUid { get; set; }

    [Column("ItemUID")]
    public Guid ItemUid { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal SalesQty { get; set; }

    [Column(TypeName = "decimal(38, 3)")]
    public decimal SalesReturnQty { get; set; }

    [Column(TypeName = "decimal(22, 3)")]
    public decimal? SalesValue { get; set; }

    [Column(TypeName = "decimal(38, 3)")]
    public decimal SalesReturnValue { get; set; }

    [Column(TypeName = "decimal(38, 3)")]
    public decimal? NetQty { get; set; }

    [Column(TypeName = "decimal(38, 3)")]
    public decimal? NetValue { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SalesType { get; set; }
}
