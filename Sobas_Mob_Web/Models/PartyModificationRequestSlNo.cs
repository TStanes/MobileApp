using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Keyless]
[Table("PartyModificationRequestSlNo")]
public partial class PartyModificationRequestSlNo
{
    [StringLength(100)]
    public string TableName { get; set; } = null!;

    [StringLength(5)]
    public string BranchCode { get; set; } = null!;

    public int FinYear { get; set; }

    public int LastReqNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Modifieddate { get; set; }
}
