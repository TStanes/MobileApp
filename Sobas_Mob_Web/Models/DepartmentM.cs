using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("DepartmentM")]
public partial class DepartmentM
{
    [Key]
    [Column("DepartmentUID")]
    public Guid DepartmentUid { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string DepartmentCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string DepartmentDesc { get; set; } = null!;

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
