using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Table("EJVVoucherUpdation")]
public partial class EjvvoucherUpdation
{
    [Key]
    [Column("EJVVoucherUpdationUID")]
    public Guid EjvvoucherUpdationUid { get; set; }

    [Column("EJVAcknowledgeUpdationUID")]
    public Guid EjvacknowledgeUpdationUid { get; set; }

    [Column("VoucherHeaderUID")]
    public Guid VoucherHeaderUid { get; set; }

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

    [ForeignKey("VoucherHeaderUid")]
    [InverseProperty("EjvvoucherUpdations")]
    public virtual VoucherHeader VoucherHeaderU { get; set; } = null!;
}
