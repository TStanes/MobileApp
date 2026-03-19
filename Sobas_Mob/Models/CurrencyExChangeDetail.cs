using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

public partial class CurrencyExChangeDetail
{
    [Key]
    [Column("CurrencyExChangeUID")]
    public Guid CurrencyExChangeUid { get; set; }

    [Column("CurrencyUID")]
    public Guid CurrencyUid { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime EffectiveDate { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal Rate { get; set; }

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
}
