using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("VechicleTran")]
[Index("VechicleUid", "EffectiveFromDate", Name = "_dta_index_VechicleTran_5_376596630__K2_K17_12")]
public partial class VechicleTran
{
    [Key]
    [Column("VechicleTranUID")]
    public Guid VechicleTranUid { get; set; }

    [Column("VechicleUID")]
    public Guid VechicleUid { get; set; }

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

    [Column("EmployeeID")]
    public int EmployeeId { get; set; }

    [StringLength(100)]
    public string OwnedBy { get; set; } = null!;

    [StringLength(100)]
    public string VechicleCategory { get; set; } = null!;

    public int ModelNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime RegistrationDate { get; set; }

    [StringLength(250)]
    public string? Remarks { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EffectiveFromDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EffectiveToDate { get; set; }

    [ForeignKey("VechicleUid")]
    [InverseProperty("VechicleTrans")]
    public virtual VechicleM VechicleU { get; set; } = null!;
}
