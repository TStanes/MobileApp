using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Keyless]
public partial class TransactionSlNo
{
    [StringLength(100)]
    public string TableName { get; set; } = null!;

    [StringLength(5)]
    public string BranchCode { get; set; } = null!;

    public int Yr { get; set; }

    public int LastNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDate { get; set; }
}
