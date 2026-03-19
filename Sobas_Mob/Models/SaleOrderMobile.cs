using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("Sale_Order_Mobile")]
public partial class SaleOrderMobile
{
    [Key]
    [Column("UniqID")]
    public Guid UniqId { get; set; }

    [Column("SNo")]
    public int Sno { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string PartyCode { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string PartyName { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string ItemCode { get; set; } = null!;

    [StringLength(255)]
    [Unicode(false)]
    public string ItemDescription { get; set; } = null!;

    [StringLength(255)]
    [Unicode(false)]
    public string? Remarks { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDate { get; set; }

    public int? Quantity { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Rate { get; set; }
}
