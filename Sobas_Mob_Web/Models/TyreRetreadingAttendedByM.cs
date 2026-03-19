using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("TyreRetreadingAttendedByM")]
public partial class TyreRetreadingAttendedByM
{
    [Key]
    [Column("TyreRetreadingAttendedByUID")]
    public Guid TyreRetreadingAttendedByUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string AttendedByCode { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string AttendedByName { get; set; } = null!;

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
