using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("StockPointCommissionDetail_New")]
public partial class StockPointCommissionDetailNew
{
    [Key]
    [Column("StockPointCommissionDetailUID")]
    public Guid StockPointCommissionDetailUid { get; set; }

    [Column("StockPointCommissionUID")]
    public Guid StockPointCommissionUid { get; set; }

    [Column("ItemUID")]
    public Guid ItemUid { get; set; }

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

    [ForeignKey("ItemUid")]
    [InverseProperty("StockPointCommissionDetailNews")]
    public virtual ItemM ItemU { get; set; } = null!;

    [ForeignKey("StockPointCommissionUid")]
    [InverseProperty("StockPointCommissionDetailNews")]
    public virtual StockPointCommissionMNew StockPointCommissionU { get; set; } = null!;
}
