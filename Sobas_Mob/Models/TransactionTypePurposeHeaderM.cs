using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("TransactionTypePurposeHeaderM")]
public partial class TransactionTypePurposeHeaderM
{
    [Key]
    [Column("TransactionTypePurposeUID")]
    public Guid TransactionTypePurposeUid { get; set; }

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

    [InverseProperty("TransactionTypePurposeU")]
    public virtual ICollection<TransactionTypePurposeDetailM> TransactionTypePurposeDetailMs { get; set; } = new List<TransactionTypePurposeDetailM>();

    [ForeignKey("TransactiontypesUid")]
    [InverseProperty("TransactionTypePurposeHeaderMs")]
    public virtual TransactionTypesM TransactiontypesU { get; set; } = null!;
}
