using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

public partial class InventoryMailDatum
{
    [Key]
    [Column("InventoryMailUID")]
    public Guid InventoryMailUid { get; set; }

    [StringLength(2)]
    public string DivisionCode { get; set; } = null!;

    [StringLength(3)]
    public string BranchCode { get; set; } = null!;

    [StringLength(1000)]
    public string MailTo { get; set; } = null!;

    [Column("CCTo")]
    [StringLength(1000)]
    public string? Ccto { get; set; }

    [Column("BCCTo")]
    [StringLength(1000)]
    public string? Bccto { get; set; }

    [StringLength(1000)]
    public string? MailSub { get; set; }

    [StringLength(1000)]
    public string? MailContent { get; set; }

    [Column("isActive")]
    public bool? IsActive { get; set; }

    [StringLength(50)]
    public string CreatedByy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime Createddate { get; set; }

    [StringLength(50)]
    public string ModifiedBy { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ModifiedDate { get; set; }
}
