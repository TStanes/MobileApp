using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
public partial class MonthWiseSale
{
    [Column("DivisionUID")]
    public Guid? DivisionUid { get; set; }

    [Column("SOUID")]
    public Guid? Souid { get; set; }

    [Column("ItemUID")]
    public Guid? ItemUid { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? SalesQty { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? SalesValue { get; set; }

    public int? SalesMonth { get; set; }

    public int? SalesYear { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? SalesMonthDate { get; set; }

    public int? FinYear { get; set; }

    public bool? IsActive { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDate { get; set; }
}
