using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
public partial class DeletedRow
{
    [Column("DeletedRowsUID")]
    public Guid DeletedRowsUid { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string MenuDesc { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string TableName { get; set; } = null!;

    [Column("TableUID")]
    public Guid TableUid { get; set; }

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
