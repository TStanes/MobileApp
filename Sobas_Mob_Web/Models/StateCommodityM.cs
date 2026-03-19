using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("StateCommodityM")]
public partial class StateCommodityM
{
    [Key]
    [Column("StateCommodityUID")]
    public Guid StateCommodityUid { get; set; }

    [Column("CommodityUID")]
    public Guid CommodityUid { get; set; }

    [Column("StateUID")]
    public Guid StateUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ScheduleNo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SerialNo { get; set; }

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

    [ForeignKey("CommodityUid")]
    [InverseProperty("StateCommodityMs")]
    public virtual CommodityCodeM CommodityU { get; set; } = null!;

    [ForeignKey("StateUid")]
    [InverseProperty("StateCommodityMs")]
    public virtual StateM1 StateU { get; set; } = null!;
}
