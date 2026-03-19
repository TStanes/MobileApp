using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("CashFlowGroupM")]
public partial class CashFlowGroupM
{
    [Key]
    [Column("CashFlowGroupUID")]
    public Guid CashFlowGroupUid { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string CashFlowGroupCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string CashFlowGroupDesc { get; set; } = null!;

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
