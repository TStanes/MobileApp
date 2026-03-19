using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("CurrencyM")]
public partial class CurrencyM
{
    [Key]
    [Column("CurrencyUID")]
    public Guid CurrencyUid { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string CurrencyCode { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string CurrencyDesc { get; set; } = null!;

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

    [InverseProperty("CurrencyU")]
    public virtual ICollection<ProformaInvoiceDetail> ProformaInvoiceDetails { get; set; } = new List<ProformaInvoiceDetail>();
}
