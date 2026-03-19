using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("AccountGroupM")]
public partial class AccountGroupM
{
    [Key]
    [Column("AccountGroupUID")]
    public Guid AccountGroupUid { get; set; }

    [Column("AccountUID")]
    public Guid AccountUid { get; set; }

    [Column("UnderAccountUID")]
    public Guid? UnderAccountUid { get; set; }

    [StringLength(800)]
    [Unicode(false)]
    public string AccountDescription { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string ShortName { get; set; } = null!;

    [StringLength(800)]
    [Unicode(false)]
    public string PrintDescription { get; set; } = null!;

    public int AccountGroupType { get; set; }

    [Column("HLevel")]
    public int Hlevel { get; set; }

    public bool IsFixed { get; set; }

    public bool IsControlAccount { get; set; }

    public bool IsSubsibaryLedger { get; set; }

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

    [ForeignKey("UnderAccountUid")]
    [InverseProperty("AccountGroupMs")]
    public virtual AccountM? UnderAccountU { get; set; }
}
