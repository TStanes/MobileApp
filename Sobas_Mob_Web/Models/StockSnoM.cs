using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("StockSnoM")]
public partial class StockSnoM
{
    [Key]
    [Column("StockSNOUID")]
    public Guid StockSnouid { get; set; }

    [Column("BranchUID")]
    public Guid BranchUid { get; set; }

    [Column("InvTransactionTypeUID")]
    public Guid InvTransactionTypeUid { get; set; }

    [Column("StockSNOCode")]
    public short StockSnocode { get; set; }

    [Column("StockSNODesc")]
    [StringLength(50)]
    [Unicode(false)]
    public string StockSnodesc { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime EffFromDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime EffToDate { get; set; }

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
