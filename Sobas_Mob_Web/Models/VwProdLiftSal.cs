using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Keyless]
public partial class VwProdLiftSal
{
    [Column("PartyID")]
    [StringLength(15)]
    [Unicode(false)]
    public string? PartyId { get; set; }

    [Column("PARTYNAM")]
    [StringLength(150)]
    [Unicode(false)]
    public string? Partynam { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? InvoiceNo { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime InvDate { get; set; }

    [Column("ITEMHEAD")]
    [StringLength(14)]
    [Unicode(false)]
    public string? Itemhead { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string Trantype { get; set; } = null!;

    [Column("PACKCOD")]
    [StringLength(4)]
    [Unicode(false)]
    public string? Packcod { get; set; }

    [Column("salqty", TypeName = "decimal(18, 5)")]
    public decimal Salqty { get; set; }

    [Column("slsrtnqty", TypeName = "decimal(18, 5)")]
    public decimal Slsrtnqty { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Rate { get; set; }

    [Column("GDesc")]
    [StringLength(150)]
    [Unicode(false)]
    public string? Gdesc { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? SoName { get; set; }

    [Column("itemhead_desc")]
    [StringLength(150)]
    [Unicode(false)]
    public string ItemheadDesc { get; set; } = null!;

    [Column("Branch_Code")]
    [StringLength(50)]
    [Unicode(false)]
    public string? BranchCode { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string Isubgrp { get; set; } = null!;

    [Column("subgrpnam")]
    [StringLength(150)]
    [Unicode(false)]
    public string Subgrpnam { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string ItemDesc { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string ItemCode { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string PackCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string PackDesc { get; set; } = null!;

    [Column("ItemSubGroupUID")]
    public Guid ItemSubGroupUid { get; set; }

    [Column("DivisionUID")]
    public Guid? DivisionUid { get; set; }

    [Column("BranchUID")]
    public Guid? BranchUid { get; set; }

    [Column("ItemUID")]
    public Guid ItemUid { get; set; }
}
