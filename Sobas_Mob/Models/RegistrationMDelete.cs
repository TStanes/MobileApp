using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("RegistrationM_Delete")]
public partial class RegistrationMDelete
{
    [Key]
    [Column("RegistrationUID")]
    public Guid RegistrationUid { get; set; }

    [Column("StateUID")]
    public Guid StateUid { get; set; }

    [Column("TINNo")]
    [StringLength(50)]
    [Unicode(false)]
    public string Tinno { get; set; } = null!;

    [Column("TINDt", TypeName = "datetime")]
    public DateTime Tindt { get; set; }

    [Column("CSTNo")]
    [StringLength(50)]
    [Unicode(false)]
    public string Cstno { get; set; } = null!;

    [Column("CSTDate", TypeName = "datetime")]
    public DateTime Cstdate { get; set; }

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

    [ForeignKey("StateUid")]
    [InverseProperty("RegistrationMDeletes")]
    public virtual StateM1 StateU { get; set; } = null!;
}
