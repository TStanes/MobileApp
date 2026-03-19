using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Keyless]
public partial class VwConsolidatedMonthlyOutstandingReceivable
{
    [Column("CMORUID")]
    public Guid Cmoruid { get; set; }

    public int Month { get; set; }

    public int Year { get; set; }

    [Column("StateUID")]
    public Guid StateUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string StateCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string StateDesc { get; set; } = null!;

    [Column("BranchUID")]
    public Guid BranchUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string BranchCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string BranchName { get; set; } = null!;

    [Column("DivisionUID")]
    public Guid DivisionUid { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string DivisionCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string DivisionDesc { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? PrincipleName { get; set; }

    [Column("PartyUID")]
    public Guid PartyUid { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? PartyCode { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string PartyName { get; set; } = null!;

    [Column("SOUID")]
    public Guid? Souid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string SoCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string SoName { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string AreaCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string AreaDesc { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string DocNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime DocDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DueDate { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Receivable { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime AsOnDate { get; set; }

    public bool DelFlag { get; set; }

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
}
