using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
public partial class VwVoudb
{
    [Column("VoucherHeaderUID")]
    public Guid VoucherHeaderUid { get; set; }

    [Column("Voucher_No")]
    [StringLength(20)]
    [Unicode(false)]
    public string? VoucherNo { get; set; }

    [Column("Branch_Code")]
    [StringLength(50)]
    [Unicode(false)]
    public string BranchCode { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? PartyId { get; set; }

    [Column("GDesc")]
    [StringLength(814)]
    [Unicode(false)]
    public string? Gdesc { get; set; }

    [Column("dr", TypeName = "decimal(38, 3)")]
    public decimal? Dr { get; set; }
}
