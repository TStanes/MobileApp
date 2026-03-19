using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Keyless]
[Table("DocumentSlNos_EDSales")]
public partial class DocumentSlNosEdsale
{
    [StringLength(3)]
    [Unicode(false)]
    public string BranchCode { get; set; } = null!;

    [Column("EDType")]
    [StringLength(1)]
    [Unicode(false)]
    public string Edtype { get; set; } = null!;

    public int Yr { get; set; }

    public int LastNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDate { get; set; }
}
