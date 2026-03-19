using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Keyless]
public partial class VwChqDebitDet
{
    [Column("VoucherHeaderUID")]
    public Guid VoucherHeaderUid { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? PartyId { get; set; }

    [Column("Voucher_No")]
    [StringLength(20)]
    [Unicode(false)]
    public string? VoucherNo { get; set; }

    [Column("BranchUID")]
    public Guid BranchUid { get; set; }

    [Column("Branch_Code")]
    [StringLength(50)]
    [Unicode(false)]
    public string BranchCode { get; set; } = null!;

    [Column("GDesc")]
    [StringLength(150)]
    [Unicode(false)]
    public string Gdesc { get; set; } = null!;

    [Column("partynam")]
    [StringLength(150)]
    [Unicode(false)]
    public string Partynam { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string? SoName { get; set; }

    public bool Deleted { get; set; }
}
