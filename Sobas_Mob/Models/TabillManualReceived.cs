using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("TABillManualReceived")]
[Index("TabillNo", Name = "_dta_index_TABillManualReceived_5_1145315390__K2")]
public partial class TabillManualReceived
{
    [Key]
    [Column("TabillUID")]
    public Guid TabillUid { get; set; }

    [StringLength(500)]
    public string? TabillNo { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal BusTrainFee { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal RoomRent { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Postage { get; set; }

    [Column("DDCommision", TypeName = "decimal(18, 2)")]
    public decimal Ddcommision { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal PetrolValue { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal RepairValue { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Batta { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal PhoneCharge { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Stationary { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal OtherExps { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal OilValue { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Total { get; set; }

    [StringLength(10)]
    public string IsDuduction { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ReceivedDate { get; set; }

    [StringLength(500)]
    public string DuductedReason { get; set; } = null!;

    [StringLength(10)]
    public string Isactive { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string CreatedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime CreatedDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ModifiedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ModifiedDate { get; set; }
}
