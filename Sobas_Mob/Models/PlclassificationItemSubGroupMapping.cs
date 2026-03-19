using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("PLClassificationItemSubGroupMapping")]
public partial class PlclassificationItemSubGroupMapping
{
    [Key]
    [Column("PLClassificationItemSubGroupMappingUID")]
    public Guid PlclassificationItemSubGroupMappingUid { get; set; }

    [Column("PLClassificationMUID")]
    public Guid PlclassificationMuid { get; set; }

    [Column("ItemSubGroupUID")]
    public Guid ItemSubGroupUid { get; set; }

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

    [ForeignKey("PlclassificationMuid")]
    [InverseProperty("PlclassificationItemSubGroupMappings")]
    public virtual PlclassificationM PlclassificationMu { get; set; } = null!;
}
