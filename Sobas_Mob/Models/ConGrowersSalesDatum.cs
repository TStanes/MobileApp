using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
public partial class ConGrowersSalesDatum
{
    [Column("Area Code")]
    [StringLength(3)]
    public string? AreaCode { get; set; }

    [Column("Area Name")]
    [StringLength(200)]
    public string? AreaName { get; set; }

    [Column("Zone Code")]
    [StringLength(2)]
    public string? ZoneCode { get; set; }

    [Column("Zone Name")]
    [StringLength(200)]
    public string? ZoneName { get; set; }

    [StringLength(200)]
    public string? TransactionTypeDesc { get; set; }

    [StringLength(20)]
    public string? EntityNumber { get; set; }

    [StringLength(10)]
    public string? SalesType { get; set; }

    [Column("Invoice Number")]
    [StringLength(50)]
    public string? InvoiceNumber { get; set; }

    [Column("Invoice Date", TypeName = "datetime")]
    public DateTime? InvoiceDate { get; set; }

    [StringLength(100)]
    public string? PrincipleName { get; set; }

    public bool? Interstate { get; set; }

    [StringLength(10)]
    public string? FrieghtPaymentType { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? FrieghtPlus { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? FrieghtMinus { get; set; }

    [Column("InventoryTransListUID", TypeName = "decimal(18, 0)")]
    public decimal? InventoryTransListUid { get; set; }

    [StringLength(50)]
    public string? ItemCode { get; set; }

    [StringLength(200)]
    public string? ItemDesc { get; set; }

    [StringLength(100)]
    public string? SeedVariety { get; set; }

    [StringLength(100)]
    public string? SeedCategory { get; set; }

    [StringLength(100)]
    public string? SeedType { get; set; }

    [StringLength(100)]
    public string? BatchNo { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? NetQty { get; set; }

    [Column("MFGDt", TypeName = "datetime")]
    public DateTime? Mfgdt { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ExpDt { get; set; }

    public int? NoOfCases { get; set; }
}
