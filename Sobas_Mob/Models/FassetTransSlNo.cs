using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("FAssetTransSlNos")]
public partial class FassetTransSlNo
{
    [StringLength(100)]
    public string TableName { get; set; } = null!;

    [StringLength(50)]
    public string TransactionsType { get; set; } = null!;

    public int Yr { get; set; }

    public int LastNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDate { get; set; }
}
