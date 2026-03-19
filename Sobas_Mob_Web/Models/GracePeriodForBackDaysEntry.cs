using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("GracePeriodForBackDaysEntry")]
public partial class GracePeriodForBackDaysEntry
{
    [Key]
    [Column("GraceperiodforbackdaysUID")]
    public Guid GraceperiodforbackdaysUid { get; set; }

    public int GracePeriod { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime Lastprocessdate { get; set; }

    public int Lastprocessmonth { get; set; }

    public int Lastprocessyear { get; set; }

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
