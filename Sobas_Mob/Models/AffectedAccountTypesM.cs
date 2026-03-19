using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("AffectedAccountTypesM")]
public partial class AffectedAccountTypesM
{
    [Key]
    [Column("AffectedAccountTypesUID")]
    public Guid AffectedAccountTypesUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? AffectedAccountTypesCode { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string AffectedAccountTypesName { get; set; } = null!;

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

    [InverseProperty("AffectedAccountTypesU")]
    public virtual ICollection<LedgerTemplateMappingM> LedgerTemplateMappingMs { get; set; } = new List<LedgerTemplateMappingM>();
}
