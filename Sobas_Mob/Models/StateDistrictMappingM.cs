using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("StateDistrictMappingM")]
public partial class StateDistrictMappingM
{
    [Key]
    [Column("StateDistrictMappingUID")]
    public Guid StateDistrictMappingUid { get; set; }

    [Column("StateUID")]
    public Guid StateUid { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string DistrictCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string DistrictDesc { get; set; } = null!;

    public bool IsActive { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string CreatedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime CreatedDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Modifiedby { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ModifiedDate { get; set; }
}
