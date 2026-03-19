using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Keyless]
public partial class TempBulkUpdatePartyCreditDay
{
    [StringLength(15)]
    [Unicode(false)]
    public string? PartyCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? PartyName { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? DivisionCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PrincipleName { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal? CreditDays { get; set; }
}
