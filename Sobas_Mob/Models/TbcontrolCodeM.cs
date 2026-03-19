using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("TBControlCodeM")]
public partial class TbcontrolCodeM
{
    [Key]
    [Column("TBControlCodeUID")]
    public Guid TbcontrolCodeUid { get; set; }

    [Column("ControlAccountUID")]
    public Guid ControlAccountUid { get; set; }

    public int StateLevel { get; set; }

    public int BranchLevel { get; set; }

    public int DivisionLevel { get; set; }

    public int CategoryLevel { get; set; }

    public int SubGroupLevel { get; set; }

    public int Slno { get; set; }

    [Column("HLevel")]
    public int Hlevel { get; set; }

    [Column("IsTTC")]
    public bool IsTtc { get; set; }

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

    [ForeignKey("ControlAccountUid")]
    [InverseProperty("TbcontrolCodeMs")]
    public virtual AccountM ControlAccountU { get; set; } = null!;

    [InverseProperty("TbcontrolCodeU")]
    public virtual ICollection<TbaccountGroupM> TbaccountGroupMs { get; set; } = new List<TbaccountGroupM>();

    [InverseProperty("TbcontrolCodeU")]
    public virtual ICollection<TbaccountM> TbaccountMs { get; set; } = new List<TbaccountM>();
}
