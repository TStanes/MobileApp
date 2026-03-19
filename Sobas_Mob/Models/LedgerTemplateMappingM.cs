using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("LedgerTemplateMappingM")]
public partial class LedgerTemplateMappingM
{
    [Key]
    [Column("LedgerTemplateMappingUID")]
    public Guid LedgerTemplateMappingUid { get; set; }

    [Column("LedgerTemplatesUID")]
    public Guid LedgerTemplatesUid { get; set; }

    [Column("AffectedAccountTypesUID")]
    public Guid AffectedAccountTypesUid { get; set; }

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

    [ForeignKey("AffectedAccountTypesUid")]
    [InverseProperty("LedgerTemplateMappingMs")]
    public virtual AffectedAccountTypesM AffectedAccountTypesU { get; set; } = null!;

    [ForeignKey("LedgerTemplatesUid")]
    [InverseProperty("LedgerTemplateMappingMs")]
    public virtual LedgerTemplatesM LedgerTemplatesU { get; set; } = null!;
}
