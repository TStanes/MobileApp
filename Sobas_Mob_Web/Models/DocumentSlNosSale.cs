using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Keyless]
public partial class DocumentSlNosSale
{
    [StringLength(3)]
    [Unicode(false)]
    public string BranchCode { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string DivisionCode { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string PrincipleSlNoCode { get; set; } = null!;

    public int LastNo { get; set; }

    public short StockSno { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDate { get; set; }
}
