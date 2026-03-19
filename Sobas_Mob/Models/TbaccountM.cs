using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("TBAccountM")]
[Index("AccountUid", "TbcontrolCodeUid", Name = "_dta_index_TBAccountM_7_1687833225__K4_K2_3")]
public partial class TbaccountM
{
    [Key]
    [Column("TBAccountUID")]
    public Guid TbaccountUid { get; set; }

    [Column("TBControlCodeUID")]
    public Guid TbcontrolCodeUid { get; set; }

    [Column("TBAccountGroupUID")]
    public Guid? TbaccountGroupUid { get; set; }

    [Column("AccountUID")]
    public Guid AccountUid { get; set; }

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

    [ForeignKey("AccountUid")]
    [InverseProperty("TbaccountMs")]
    public virtual AccountM AccountU { get; set; } = null!;

    [ForeignKey("TbcontrolCodeUid")]
    [InverseProperty("TbaccountMs")]
    public virtual TbcontrolCodeM TbcontrolCodeU { get; set; } = null!;
}
