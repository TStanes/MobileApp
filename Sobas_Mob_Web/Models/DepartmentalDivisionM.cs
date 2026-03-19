using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("DepartmentalDivisionM")]
public partial class DepartmentalDivisionM
{
    [Key]
    [Column("DepartmentalDivisionUID")]
    public Guid DepartmentalDivisionUid { get; set; }

    [StringLength(50)]
    public string DepartmentalDivisionCode { get; set; } = null!;

    [StringLength(150)]
    public string DepartmentalDivisionName { get; set; } = null!;

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
