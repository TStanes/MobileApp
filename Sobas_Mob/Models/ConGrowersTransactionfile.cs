using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("ConGrowersTransactionfile")]
public partial class ConGrowersTransactionfile
{
    [Column("Area Code")]
    [StringLength(50)]
    [Unicode(false)]
    public string AreaCode { get; set; } = null!;

    [Column("Area Name")]
    [StringLength(150)]
    [Unicode(false)]
    public string AreaName { get; set; } = null!;

    [Column("Zone Code")]
    [StringLength(50)]
    [Unicode(false)]
    public string ZoneCode { get; set; } = null!;

    [Column("Zone Name")]
    [StringLength(150)]
    [Unicode(false)]
    public string ZoneName { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string TransactionTypeDesc { get; set; } = null!;

    [StringLength(15)]
    [Unicode(false)]
    public string? EntityNumber { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SalesType { get; set; }

    [Column("Invoice Number")]
    [StringLength(20)]
    [Unicode(false)]
    public string? InvoiceNumber { get; set; }

    [Column("Invoice Date", TypeName = "datetime")]
    public DateTime InvoiceDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PrincipleName { get; set; }

    public bool Interstate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? FrieghtPaymentType { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? FrieghtPlus { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? FrieghtMinus { get; set; }

    [Column("InventoryTransListUID", TypeName = "decimal(18, 0)")]
    public decimal InventoryTransListUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ItemCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string ItemDesc { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string SeedVariety { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string SeedType { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string SeedCategory { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? BatchNo { get; set; }

    [Column(TypeName = "decimal(18, 5)")]
    public decimal NetQty { get; set; }

    [Column("MFGDt", TypeName = "datetime")]
    public DateTime Mfgdt { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ExpDt { get; set; }

    public int NoOfCases { get; set; }
}
