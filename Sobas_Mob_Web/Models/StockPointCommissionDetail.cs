using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("StockPointCommissionDetail")]
public partial class StockPointCommissionDetail
{
    [Key]
    [Column("StockPointCommissionDetailUID")]
    public Guid StockPointCommissionDetailUid { get; set; }

    [Column("StockPointCommisionUID")]
    public Guid StockPointCommisionUid { get; set; }

    [Column("DivisionPrincipleUID")]
    public Guid? DivisionPrincipleUid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime FromDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ToDate { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal FromQty { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal ToQty { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal FromValue { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal ToValue { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal CommissionAmt { get; set; }

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

    [Column("AccountUID")]
    public Guid AccountUid { get; set; }

    [Column("ItemUID")]
    public Guid? ItemUid { get; set; }

    [ForeignKey("AccountUid")]
    [InverseProperty("StockPointCommissionDetails")]
    public virtual AccountM AccountU { get; set; } = null!;

    [ForeignKey("DivisionPrincipleUid")]
    [InverseProperty("StockPointCommissionDetails")]
    public virtual DivisionPrincipleM? DivisionPrincipleU { get; set; }

    [ForeignKey("StockPointCommisionUid")]
    [InverseProperty("StockPointCommissionDetails")]
    public virtual StockPointCommisionM StockPointCommisionU { get; set; } = null!;
}
