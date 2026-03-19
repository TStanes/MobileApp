using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Keyless]
public partial class VwVoucr
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

    [StringLength(15)]
    [Unicode(false)]
    public string? PartyId { get; set; }

    [Column("cr", TypeName = "decimal(38, 3)")]
    public decimal? Cr { get; set; }

    [Column("GDesc")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Gdesc { get; set; }
}
