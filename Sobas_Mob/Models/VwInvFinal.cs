using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
public partial class VwInvFinal
{
    [Column("partynam")]
    [StringLength(150)]
    [Unicode(false)]
    public string Partynam { get; set; } = null!;

    [Column("partyad1")]
    [StringLength(150)]
    [Unicode(false)]
    public string Partyad1 { get; set; } = null!;

    [Column("partyad2")]
    [StringLength(150)]
    [Unicode(false)]
    public string Partyad2 { get; set; } = null!;

    [Column("partyad3")]
    [StringLength(150)]
    [Unicode(false)]
    public string Partyad3 { get; set; } = null!;

    [Column("partyad4")]
    [StringLength(150)]
    [Unicode(false)]
    public string Partyad4 { get; set; } = null!;

    [Column("partycty")]
    [StringLength(50)]
    [Unicode(false)]
    public string Partycty { get; set; } = null!;

    [Column("PartyID")]
    [StringLength(15)]
    [Unicode(false)]
    public string? PartyId { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? Carrier { get; set; }

    [Column("LRDetails")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Lrdetails { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? SalesOfficer { get; set; }

    [Column("DCNo")]
    [StringLength(20)]
    [Unicode(false)]
    public string Dcno { get; set; } = null!;

    [Column("DCDt", TypeName = "datetime")]
    public DateTime Dcdt { get; set; }

    [Column("FRTPL", TypeName = "decimal(18, 3)")]
    public decimal? Frtpl { get; set; }

    [Column("FRTMI", TypeName = "decimal(18, 3)")]
    public decimal? Frtmi { get; set; }

    [Column("rooff", TypeName = "decimal(18, 3)")]
    public decimal Rooff { get; set; }

    [Column("brnam")]
    [StringLength(150)]
    [Unicode(false)]
    public string Brnam { get; set; } = null!;

    [Column("brad1")]
    [StringLength(150)]
    [Unicode(false)]
    public string Brad1 { get; set; } = null!;

    [Column("brad2")]
    [StringLength(150)]
    [Unicode(false)]
    public string Brad2 { get; set; } = null!;

    [Column("brad3")]
    [StringLength(150)]
    [Unicode(false)]
    public string Brad3 { get; set; } = null!;

    [Column("brcty")]
    [StringLength(50)]
    [Unicode(false)]
    public string Brcty { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string Expr2 { get; set; } = null!;

    [Column("Branch_Code")]
    [StringLength(50)]
    [Unicode(false)]
    public string BranchCode { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string InvoiceNo { get; set; } = null!;

    [Column("Invoice_Ident")]
    [StringLength(150)]
    [Unicode(false)]
    public string InvoiceIdent { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string BatchNo { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime ExpDate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string ItemCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string ItemDesc { get; set; } = null!;

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Qty { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Rate { get; set; }

    [Column("ST", TypeName = "decimal(18, 2)")]
    public decimal St { get; set; }

    [Column("STDesc")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Stdesc { get; set; }

    [Column("ED", TypeName = "decimal(18, 2)")]
    public decimal Ed { get; set; }

    [Column("EDDesc")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Eddesc { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal CessonEd { get; set; }

    [Column("SC", TypeName = "decimal(18, 2)")]
    public decimal? Sc { get; set; }

    [Column("ST_AMT", TypeName = "decimal(18, 3)")]
    public decimal StAmt { get; set; }

    [Column("ED_AMT", TypeName = "decimal(18, 3)")]
    public decimal EdAmt { get; set; }

    [Column("SC_AMT", TypeName = "decimal(18, 3)")]
    public decimal? ScAmt { get; set; }

    [Column("CessonEDAmt", TypeName = "decimal(18, 3)")]
    public decimal CessonEdamt { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Discount1Per { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Discount2Per { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal Discount3Per { get; set; }

    [Column(TypeName = "decimal(18, 2)")]
    public decimal OtherPer { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Discount1 { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Discount2 { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Discount3 { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal OtherDiscount { get; set; }

    public int NoOfCase { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal TotalAmt { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime MfgDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime InvDate { get; set; }

    [Column("OTHER", TypeName = "decimal(18, 3)")]
    public decimal? Other { get; set; }

    [Column("ptynam")]
    [StringLength(150)]
    [Unicode(false)]
    public string? Ptynam { get; set; }

    [Column("ptyad1")]
    [StringLength(150)]
    [Unicode(false)]
    public string? Ptyad1 { get; set; }

    [Column("ptyad2")]
    [StringLength(150)]
    [Unicode(false)]
    public string? Ptyad2 { get; set; }

    [Column("ptyad3")]
    [StringLength(150)]
    [Unicode(false)]
    public string? Ptyad3 { get; set; }

    [Column("ptyad4")]
    [StringLength(150)]
    [Unicode(false)]
    public string? Ptyad4 { get; set; }

    [Column("ptycty")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Ptycty { get; set; }

    [Column("ptylst")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Ptylst { get; set; }

    public bool? DelRecord { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string Trantype { get; set; } = null!;

    [Column("MRP", TypeName = "decimal(18, 3)")]
    public decimal Mrp { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? SoName { get; set; }

    [Column("TransID")]
    public Guid TransId { get; set; }

    [Column("brlst")]
    [StringLength(1)]
    [Unicode(false)]
    public string Brlst { get; set; } = null!;

    [Column("stcon")]
    [StringLength(50)]
    [Unicode(false)]
    public string Stcon { get; set; } = null!;

    [Column("decl")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Decl { get; set; }

    [Column("desc")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Desc { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string Igrp { get; set; } = null!;

    [Column("Commodity_code")]
    [StringLength(10)]
    [Unicode(false)]
    public string? CommodityCode { get; set; }

    [Column("Schedule_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ScheduleNo { get; set; }

    [Column("BRCOD_NAM")]
    [StringLength(203)]
    [Unicode(false)]
    public string BrcodNam { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string RupeesInWords { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string Repdesc { get; set; } = null!;

    [Column(TypeName = "decimal(18, 3)")]
    public decimal InvSubtot { get; set; }

    public bool InterState { get; set; }

    [Column("brad4")]
    [StringLength(150)]
    [Unicode(false)]
    public string Brad4 { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string Segment { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string Grp { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string NovaData { get; set; } = null!;

    [Column("State_Code")]
    [StringLength(50)]
    [Unicode(false)]
    public string StateCode { get; set; } = null!;

    [Column("INVTOT", TypeName = "decimal(18, 3)")]
    public decimal Invtot { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string Cst { get; set; } = null!;

    [Column("Invoice_id", TypeName = "decimal(18, 0)")]
    public decimal InvoiceId { get; set; }

    [Column("BranchUID")]
    public Guid BranchUid { get; set; }

    [Column("DivisionUID")]
    public Guid DivisionUid { get; set; }
}
