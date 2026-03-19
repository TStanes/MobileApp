using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("TaxTypeM")]
public partial class TaxTypeM
{
    [Key]
    [Column("TaxTypeUID")]
    public Guid TaxTypeUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string TaxTypeCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string TaxTypeDesc { get; set; } = null!;

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

    [InverseProperty("TaxTypeU")]
    public virtual ICollection<TaxMdetail> TaxMdetails { get; set; } = new List<TaxMdetail>();
}
