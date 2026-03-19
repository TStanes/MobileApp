using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("SMSSalesData")]
public partial class SmssalesDatum
{
    [Key]
    [Column("InventoryTransUID", TypeName = "decimal(18, 0)")]
    public decimal InventoryTransUid { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? PartyCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SalesType { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Invoiceno { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime Invoicedate { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Amount { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? MobileNo { get; set; }

    public int Flag { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime RecDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime SendDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Att1 { get; set; } = null!;
}
