using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("HSNAccountMappingM")]
public partial class HsnaccountMappingM
{
    [Key]
    [Column("HSNAccountMappingUID")]
    public Guid HsnaccountMappingUid { get; set; }

    [Column("HSNCodeUID")]
    public Guid HsncodeUid { get; set; }

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
}
