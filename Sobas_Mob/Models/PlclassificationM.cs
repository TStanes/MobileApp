using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("PLClassificationM")]
public partial class PlclassificationM
{
    [Key]
    [Column("PLClassificationMUID")]
    public Guid PlclassificationMuid { get; set; }

    [Column("PLClassification")]
    [StringLength(150)]
    public string Plclassification { get; set; } = null!;

    [Column("BranchUID")]
    public Guid BranchUid { get; set; }

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

    [InverseProperty("PlclassificationMu")]
    public virtual ICollection<PlclassificationItemSubGroupMapping> PlclassificationItemSubGroupMappings { get; set; } = new List<PlclassificationItemSubGroupMapping>();
}
