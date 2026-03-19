using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("CompanyM")]
public partial class CompanyM
{
    [Key]
    [Column("CompanyUID")]
    public Guid CompanyUid { get; set; }

    [StringLength(10)]
    public string CompanyCode { get; set; } = null!;

    [StringLength(50)]
    public string CompanyName { get; set; } = null!;

    [StringLength(150)]
    public string Address1 { get; set; } = null!;

    [StringLength(150)]
    public string Address2 { get; set; } = null!;

    [StringLength(150)]
    public string Address3 { get; set; } = null!;

    [StringLength(150)]
    public string Address4 { get; set; } = null!;

    [StringLength(50)]
    public string District { get; set; } = null!;

    [StringLength(50)]
    public string State { get; set; } = null!;

    [StringLength(50)]
    public string TaxDeductionAccount { get; set; } = null!;

    [StringLength(50)]
    public string PanNo { get; set; } = null!;

    [StringLength(600)]
    public string DeclarationStatement { get; set; } = null!;

    [StringLength(600)]
    public string Capacityof { get; set; } = null!;

    [StringLength(250)]
    [Unicode(false)]
    public string? Designation { get; set; }

    [StringLength(50)]
    public string Place { get; set; } = null!;

    public bool? IsActive { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? CreatedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CreatedDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ModifiedBy { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? ModifiedDate { get; set; }
}
