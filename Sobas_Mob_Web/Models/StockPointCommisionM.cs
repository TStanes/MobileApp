using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("StockPointCommisionM")]
public partial class StockPointCommisionM
{
    [Key]
    [Column("StockPointCommisionUID")]
    public Guid StockPointCommisionUid { get; set; }

    [Column("BranchUID")]
    public Guid BranchUid { get; set; }

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

    [ForeignKey("BranchUid")]
    [InverseProperty("StockPointCommisionMs")]
    public virtual BranchM BranchU { get; set; } = null!;

    [InverseProperty("StockPointCommisionU")]
    public virtual ICollection<StockPointCommissionDetail> StockPointCommissionDetails { get; set; } = new List<StockPointCommissionDetail>();
}
