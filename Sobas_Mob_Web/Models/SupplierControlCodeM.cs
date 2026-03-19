using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("SupplierControlCodeM")]
public partial class SupplierControlCodeM
{
    [Key]
    [Column("SupplierControlCodeUID")]
    public Guid SupplierControlCodeUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string SupplierControlCode { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string? SupplierControlDesc { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string PartyType { get; set; } = null!;

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

    [Column("AccountUID")]
    public Guid? AccountUid { get; set; }
}
