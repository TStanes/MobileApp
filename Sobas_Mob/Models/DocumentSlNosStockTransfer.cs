using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("DocumentSlNos_StockTransfer")]
public partial class DocumentSlNosStockTransfer
{
    [StringLength(3)]
    [Unicode(false)]
    public string BranchCode { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string DivisionCode { get; set; } = null!;

    public short StockSno { get; set; }

    public int LastNo { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string TransactionTypeCode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDate { get; set; }
}
