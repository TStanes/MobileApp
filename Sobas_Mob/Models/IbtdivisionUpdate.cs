using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("IBTDivisionUpdate")]
public partial class IbtdivisionUpdate
{
    [Column("VoucherHeaderUID")]
    public Guid VoucherHeaderUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? BranchCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? BranchName { get; set; }

    [Column("ParentDivisionUID")]
    public Guid? ParentDivisionUid { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? ParentDivisionCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? ParentDivisionName { get; set; }

    [Column("EntryDivisionUID")]
    public Guid? EntryDivisionUid { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? EntryDivisionCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? EntryDivisionName { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? VoucherNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? VoucherDate { get; set; }
}
