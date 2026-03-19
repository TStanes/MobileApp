using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("GrossMargin_EDVatMappingM")]
public partial class GrossMarginEdvatMappingM
{
    [Column("GrossMargin_EDVatMappingMUID")]
    public Guid GrossMarginEdvatMappingMuid { get; set; }

    [Column("ParentAccountUID")]
    public Guid ParentAccountUid { get; set; }

    [Column("AccountUID")]
    public Guid AccountUid { get; set; }

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

    [ForeignKey("AccountUid")]
    public virtual AccountM AccountU { get; set; } = null!;

    [ForeignKey("ItemSubGroupUid")]
    public virtual ItemSubGroupM ItemSubGroupU { get; set; } = null!;

    [ForeignKey("ParentAccountUid")]
    public virtual AccountM ParentAccountU { get; set; } = null!;
}
