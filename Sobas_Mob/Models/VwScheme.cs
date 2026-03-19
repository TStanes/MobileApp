using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
public partial class VwScheme
{
    [Column("DiscountUID")]
    public Guid DiscountUid { get; set; }

    [Column("DivisionUID")]
    public Guid DivisionUid { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string DiscountDesc { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string DiscountTypeCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string DiscountTypeDesc { get; set; } = null!;

    public bool? QtyLift { get; set; }

    public bool? ValueLift { get; set; }

    public bool? PaymentMade { get; set; }

    [Column("CombiID")]
    public int? CombiId { get; set; }

    public bool IsSingleInvoice { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime SchemeStartDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime SchemeEndDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? SchemeExtnDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? SchemeMatureDate { get; set; }

    public bool IsActive { get; set; }
}
