using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
public partial class TempNullDivisionVoucherHeader
{
    [Column("VoucherHeaderUID")]
    public Guid VoucherHeaderUid { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? VoucherNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? VoucherDate { get; set; }

    [StringLength(9)]
    [Unicode(false)]
    public string AccountTypeDesc { get; set; } = null!;

    [Column(TypeName = "decimal(38, 3)")]
    public decimal? Dr { get; set; }

    [Column(TypeName = "decimal(38, 3)")]
    public decimal? Cr { get; set; }

    [Column(TypeName = "decimal(38, 3)")]
    public decimal? Balance { get; set; }
}
