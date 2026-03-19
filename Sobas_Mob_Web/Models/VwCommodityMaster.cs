using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Keyless]
public partial class VwCommodityMaster
{
    [Column("CommodityUID")]
    public Guid CommodityUid { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string CommodityCode { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? ScheduleNo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? SerialNo { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string CommodityCodeDesc { get; set; } = null!;

    [Column("ItemUID")]
    public Guid ItemUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ItemCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string ItemDesc { get; set; } = null!;

    [Column("StateUID")]
    public Guid StateUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string StateCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string StateDesc { get; set; } = null!;
}
