using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("TAEmpSubM")]
public partial class TaempSubM
{
    [Key]
    [Column("EmployeeUID")]
    public Guid EmployeeUid { get; set; }

    [Column("EmployeeID")]
    public int EmployeeId { get; set; }

    [StringLength(200)]
    public string EmployeeName { get; set; } = null!;

    [Column("VechicleUID")]
    public Guid VechicleUid { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string VechicleNo { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string VechicleType { get; set; } = null!;

    public bool BattaActual { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal BattaHalf { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal BattaFull { get; set; }

    public bool RentActual { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal RentOther { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal RentCosmo { get; set; }

    public bool FuelActual { get; set; }

    [Column("FuelRateperKM", TypeName = "decimal(18, 2)")]
    public decimal FuelRateperKm { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal? Att1 { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? Att2 { get; set; }

    [Column("isActive")]
    public bool IsActive { get; set; }

    [StringLength(50)]
    public string CreatedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime CreatedDate { get; set; }

    [StringLength(50)]
    public string ModifiedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ModifiedDate { get; set; }
}
