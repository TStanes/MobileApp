using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
public partial class ItemMasterM
{
    [Column("ItemUID")]
    public Guid ItemUid { get; set; }

    [Column("ITEM CODE")]
    [StringLength(50)]
    [Unicode(false)]
    public string ItemCode { get; set; } = null!;

    [Column("DESCRIPTION")]
    [StringLength(150)]
    [Unicode(false)]
    public string Description { get; set; } = null!;

    [Column("Belongs_To")]
    [StringLength(10)]
    [Unicode(false)]
    public string BelongsTo { get; set; } = null!;

    [Column("Grouped_Under")]
    [StringLength(3)]
    [Unicode(false)]
    public string? GroupedUnder { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string Category { get; set; } = null!;

    [Column("Sale_Account_code")]
    [StringLength(3)]
    [Unicode(false)]
    public string? SaleAccountCode { get; set; }

    [Column("Sub_group")]
    [StringLength(4)]
    [Unicode(false)]
    public string SubGroup { get; set; } = null!;

    [Column("UOM")]
    [StringLength(50)]
    [Unicode(false)]
    public string Uom { get; set; } = null!;

    public int? PacKage { get; set; }

    [Column("No_Per_Package", TypeName = "decimal(10, 2)")]
    public decimal? NoPerPackage { get; set; }

    [Column("QOH")]
    public int? Qoh { get; set; }

    [Column("BOQ")]
    public int? Boq { get; set; }

    [Column("ROL", TypeName = "decimal(10, 2)")]
    public decimal? Rol { get; set; }

    [Column("MQL")]
    public int? Mql { get; set; }

    [Column("CLASS")]
    public int? Class { get; set; }

    public int? Detail { get; set; }

    [Column("Credit_days")]
    public int? CreditDays { get; set; }

    [Column("REMARKS")]
    [StringLength(150)]
    [Unicode(false)]
    public string? Remarks { get; set; }

    [Column("AREA")]
    public int? Area { get; set; }

    public bool Save { get; set; }

    public int? Packing { get; set; }

    public int? Cdata { get; set; }
}
