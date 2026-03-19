using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("TempSOWiseSales")]
public partial class TempSowiseSale
{
    [Column("DivisionUID")]
    public Guid? DivisionUid { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? DivisionCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? DivisionDesc { get; set; }

    [Column("SOUID")]
    public Guid? Souid { get; set; }

    [Column("SOCode")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Socode { get; set; }

    [Column("SOName")]
    [StringLength(150)]
    [Unicode(false)]
    public string? Soname { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? SalesValue { get; set; }
}
