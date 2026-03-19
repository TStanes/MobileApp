using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("TBAccountGroupM")]
[Index("TbcontrolCodeUid", "OriginalAccountUid", "ParentAccountCode", "ParentAccountDescription", Name = "_dta_index_TBAccountGroupM_7_420352712__K2_K5_K3_K4_1_6_7")]
public partial class TbaccountGroupM
{
    [Key]
    [Column("TBAccountGroupUID")]
    public Guid TbaccountGroupUid { get; set; }

    [Column("TBControlCodeUID")]
    public Guid TbcontrolCodeUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ParentAccountCode { get; set; }

    [StringLength(800)]
    [Unicode(false)]
    public string? ParentAccountDescription { get; set; }

    [Column("OriginalAccountUID")]
    public Guid? OriginalAccountUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string GroupCode { get; set; } = null!;

    [StringLength(800)]
    [Unicode(false)]
    public string GroupDesc { get; set; } = null!;

    [Column("StateUID")]
    public Guid? StateUid { get; set; }

    [Column("BranchUID")]
    public Guid? BranchUid { get; set; }

    [Column("DivisionUID")]
    public Guid? DivisionUid { get; set; }

    [Column("ItemCategoryUID")]
    public Guid? ItemCategoryUid { get; set; }

    [Column("ItemSubGroupUID")]
    public Guid? ItemSubGroupUid { get; set; }

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

    [ForeignKey("TbcontrolCodeUid")]
    [InverseProperty("TbaccountGroupMs")]
    public virtual TbcontrolCodeM TbcontrolCodeU { get; set; } = null!;
}
