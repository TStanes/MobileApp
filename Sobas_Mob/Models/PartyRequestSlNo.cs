using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[PrimaryKey("BranchUid", "FinYear")]
[Table("PartyRequestSlNo")]
public partial class PartyRequestSlNo
{
    [Key]
    [Column("BranchUID")]
    public Guid BranchUid { get; set; }

    [Key]
    public int FinYear { get; set; }

    public int LastReqNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Modifieddate { get; set; }
}
