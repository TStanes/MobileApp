using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
public partial class BatchSlNo
{
    [StringLength(9)]
    [Unicode(false)]
    public string BranchCode { get; set; } = null!;

    [Column("FYear")]
    public int Fyear { get; set; }

    public int LastNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDate { get; set; }
}
