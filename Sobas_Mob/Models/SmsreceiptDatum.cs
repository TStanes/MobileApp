using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("SMSReceiptData")]
public partial class SmsreceiptDatum
{
    [Key]
    [Column("VoucherheaderUID")]
    public Guid VoucherheaderUid { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? PartyCode { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string VoucherNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime Voucherdate { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Amount { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? MobileNo { get; set; }

    public int Flag { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime RecDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime SendDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Att1 { get; set; } = null!;
}
