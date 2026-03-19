using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Keyless]
public partial class VwChqRealDet
{
    [StringLength(15)]
    [Unicode(false)]
    public string? PartyId { get; set; }

    [Column("GDesc")]
    [StringLength(800)]
    [Unicode(false)]
    public string? Gdesc { get; set; }

    [Column("Ref_Voucher_No")]
    [StringLength(20)]
    [Unicode(false)]
    public string? RefVoucherNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DocDate { get; set; }

    [Column("Cheque_No")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ChequeNo { get; set; }

    [Column("Cheque_Date", TypeName = "datetime")]
    public DateTime? ChequeDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ChqRealDate { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Credit { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? Status { get; set; }

    [Column("BRNAM")]
    [StringLength(150)]
    [Unicode(false)]
    public string? Brnam { get; set; }

    [Column("Branch_Code")]
    [StringLength(50)]
    [Unicode(false)]
    public string? BranchCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? PartyName { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string Mode { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime RealDate { get; set; }
}
