using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("SalesOfficersExecutivesMappingM_SalesValue")]
public partial class SalesOfficersExecutivesMappingMSalesValue
{
    [Column("SalesOfficersExecutivesMappingMUID")]
    public Guid SalesOfficersExecutivesMappingMuid { get; set; }

    [Column("SOUID")]
    public Guid Souid { get; set; }

    [Column("MappingID")]
    public int MappingId { get; set; }

    public int MappingSlNo { get; set; }

    [Column("HeadUID")]
    public Guid HeadUid { get; set; }

    [Column("HLevel")]
    public int Hlevel { get; set; }

    public bool IsParent { get; set; }

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

    [Column(TypeName = "decimal(18, 0)")]
    public decimal SalesValue { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal SumofSalesValue { get; set; }
}
