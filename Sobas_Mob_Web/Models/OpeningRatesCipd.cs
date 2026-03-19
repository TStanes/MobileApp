using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("OpeningRatesCIPD")]
public partial class OpeningRatesCipd
{
    [Key]
    [Column("InventoryTransListUID", TypeName = "numeric(18, 0)")]
    public decimal InventoryTransListUid { get; set; }

    [Column(TypeName = "numeric(18, 3)")]
    public decimal? Rate { get; set; }

    public bool? IsActive { get; set; }

    [StringLength(10)]
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
