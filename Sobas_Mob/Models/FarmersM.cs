using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("FarmersM")]
public partial class FarmersM
{
    [Key]
    [Column("FarmerUID")]
    public Guid FarmerUid { get; set; }

    [Column("BranchUID")]
    public Guid BranchUid { get; set; }

    public int CodeSlNo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string FarmerCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string FarmerName { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string FathersName { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string DoorNo { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string StreetName { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string Taluk { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string District { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string PinCode { get; set; } = null!;

    [Column("StateUID")]
    public Guid StateUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string MobileNo { get; set; } = null!;

    [Column("EMailID")]
    [StringLength(50)]
    [Unicode(false)]
    public string EmailId { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string AadharNo { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string LandHolding { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string Crop { get; set; } = null!;

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
