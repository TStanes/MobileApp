using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Keyless]
public partial class VwSalesOfficerM
{
    [Column("SOUID")]
    public Guid Souid { get; set; }

    [Column("SOCode")]
    [StringLength(50)]
    [Unicode(false)]
    public string Socode { get; set; } = null!;

    [Column("SOName")]
    [StringLength(150)]
    [Unicode(false)]
    public string Soname { get; set; } = null!;

    [Column("SOShortName")]
    [StringLength(50)]
    [Unicode(false)]
    public string SoshortName { get; set; } = null!;

    [Column("SOFromDate", TypeName = "datetime")]
    public DateTime SofromDate { get; set; }

    [Column("SOToDate", TypeName = "datetime")]
    public DateTime SotoDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string EmpCode { get; set; } = null!;

    public bool IsActive { get; set; }

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

    [StringLength(10)]
    [Unicode(false)]
    public string AreaCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string AreaDesc { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string AreaAbbr { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime FromDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime ToDate { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? PartyCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? PartyName { get; set; }
}
