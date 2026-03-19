using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("GLCategoryM")]
public partial class GlcategoryM
{
    [Key]
    [Column("GLCategoryUID")]
    public Guid GlcategoryUid { get; set; }

    [Column("GLCategoryCode")]
    [StringLength(10)]
    [Unicode(false)]
    public string GlcategoryCode { get; set; } = null!;

    [Column("GLCategoryDesc")]
    [StringLength(150)]
    [Unicode(false)]
    public string GlcategoryDesc { get; set; } = null!;

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
