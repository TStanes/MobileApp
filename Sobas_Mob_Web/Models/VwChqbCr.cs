using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Keyless]
public partial class VwChqbCr
{
    [Column("VoucherHeaderUID")]
    public Guid VoucherHeaderUid { get; set; }

    [Column("PartyID")]
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

    [Column("Ref_Voucher_No")]
    [StringLength(20)]
    [Unicode(false)]
    public string RefVoucherNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? DocDate { get; set; }

    [Column("Reference_date", TypeName = "datetime")]
    public DateTime? ReferenceDate { get; set; }

    [Column("Reference_no")]
    [StringLength(1)]
    [Unicode(false)]
    public string ReferenceNo { get; set; } = null!;

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Credit { get; set; }

    public bool Deleted { get; set; }
}
