using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[PrimaryKey("DivisionUid", "ItemSegmentUid", "ItemCategoryUid")]
public partial class ItemCodeSlno
{
    [Key]
    [Column("DivisionUID")]
    public Guid DivisionUid { get; set; }

    [Key]
    [Column("ItemSegmentUID")]
    public Guid ItemSegmentUid { get; set; }

    [Key]
    [Column("ItemCategoryUID")]
    public Guid ItemCategoryUid { get; set; }

    public int LastNo { get; set; }
}
