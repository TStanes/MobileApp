using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Keyless]
public partial class VwDiscountItemDetail
{
    [Column("DiscountUID")]
    public Guid DiscountUid { get; set; }

    [Column("ItemUID")]
    public Guid? ItemUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ItemCode { get; set; } = null!;

    [Column("HeadItemUID")]
    public Guid? HeadItemUid { get; set; }

    [StringLength(14)]
    [Unicode(false)]
    public string? HeadItemCode { get; set; }

    [Column("ItemSubGroupUID")]
    public Guid ItemSubGroupUid { get; set; }

    public int? SchemeItemType { get; set; }
}
