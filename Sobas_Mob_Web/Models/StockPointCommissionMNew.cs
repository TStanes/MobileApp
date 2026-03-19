using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("StockPointCommissionM_New")]
public partial class StockPointCommissionMNew
{
    [Key]
    [Column("StockPointCommissionUID")]
    public Guid StockPointCommissionUid { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string StockPointCommissionDesc { get; set; } = null!;

    [Column("DivisionUID")]
    public Guid DivisionUid { get; set; }

    [Column("PartyUID")]
    public Guid PartyUid { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime FromDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ToDate { get; set; }

    [Column("RateperTL", TypeName = "decimal(18, 3)")]
    public decimal RateperTl { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal RateperCase { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal ValueinPercentage { get; set; }

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

    [InverseProperty("StockPointCommissionU")]
    public virtual ICollection<StockPointCommissionDetailNew> StockPointCommissionDetailNews { get; set; } = new List<StockPointCommissionDetailNew>();
}
