using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("LedgerTemplatesM")]
public partial class LedgerTemplatesM
{
    [Key]
    [Column("LedgerTemplatesUID")]
    public Guid LedgerTemplatesUid { get; set; }

    [Column("TransactiontypesUID")]
    public Guid TransactiontypesUid { get; set; }

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

    [InverseProperty("LedgerTemplatesU")]
    public virtual ICollection<LedgerTemplateMappingM> LedgerTemplateMappingMs { get; set; } = new List<LedgerTemplateMappingM>();

    [ForeignKey("TransactiontypesUid")]
    [InverseProperty("LedgerTemplatesMs")]
    public virtual TransactionTypesM TransactiontypesU { get; set; } = null!;
}
