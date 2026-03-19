using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
public partial class VwSalesHead
{
    [StringLength(50)]
    [Unicode(false)]
    public string? BranchCode { get; set; }

    [Column(TypeName = "decimal(18, 0)")]
    public decimal Invoiceid { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? InvoiceNo { get; set; }

    [Column("DDate", TypeName = "datetime")]
    public DateTime Ddate { get; set; }

    [Column("sCaption")]
    [StringLength(150)]
    [Unicode(false)]
    public string SCaption { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string TransType { get; set; } = null!;

    [Column("PartyID")]
    [StringLength(15)]
    [Unicode(false)]
    public string? PartyId { get; set; }

    [Column(TypeName = "decimal(12, 2)")]
    public decimal? CreditDays { get; set; }

    [Column(TypeName = "decimal(12, 4)")]
    public decimal? CreditLimit { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Discount1 { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Discount2 { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Discount3 { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Discount4 { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Ed { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal LocalTax { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? Surcharge { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Cess { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? Carrier { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? HandlingChrg { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? ClimSettlement { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal? OtherChrgs { get; set; }

    [Column("LR_Details")]
    [StringLength(20)]
    [Unicode(false)]
    public string? LrDetails { get; set; }

    public bool InterState { get; set; }

    [Column("Freight_Plus", TypeName = "decimal(18, 3)")]
    public decimal? FreightPlus { get; set; }

    [Column("Freight_Minus", TypeName = "decimal(18, 3)")]
    public decimal? FreightMinus { get; set; }

    [Column("totalamt", TypeName = "decimal(18, 3)")]
    public decimal Totalamt { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string Rupeesinwords { get; set; } = null!;

    public int Deleted { get; set; }

    [Column("SP_NAME")]
    [StringLength(150)]
    [Unicode(false)]
    public string? SpName { get; set; }

    [Column("SP_ADD1")]
    [StringLength(150)]
    [Unicode(false)]
    public string? SpAdd1 { get; set; }

    [Column("SP_ADD2")]
    [StringLength(150)]
    [Unicode(false)]
    public string? SpAdd2 { get; set; }

    [Column("SP_ADD3")]
    [StringLength(150)]
    [Unicode(false)]
    public string? SpAdd3 { get; set; }

    [Column("SP_ADD4")]
    [StringLength(150)]
    [Unicode(false)]
    public string? SpAdd4 { get; set; }

    [Column("SP_BRCD")]
    [StringLength(50)]
    [Unicode(false)]
    public string? SpBrcd { get; set; }

    [Column("SP_CST")]
    [StringLength(50)]
    [Unicode(false)]
    public string? SpCst { get; set; }

    [Column("SP_TNGST")]
    [StringLength(20)]
    [Unicode(false)]
    public string? SpTngst { get; set; }

    [Column("totcase")]
    public int? Totcase { get; set; }

    [Column("NAME")]
    [StringLength(150)]
    [Unicode(false)]
    public string? Name { get; set; }

    [Column("ADD1")]
    [StringLength(150)]
    [Unicode(false)]
    public string? Add1 { get; set; }

    [Column("ADD2")]
    [StringLength(150)]
    [Unicode(false)]
    public string? Add2 { get; set; }

    [Column("ADD3")]
    [StringLength(150)]
    [Unicode(false)]
    public string? Add3 { get; set; }

    [Column("ADD4")]
    [StringLength(150)]
    [Unicode(false)]
    public string? Add4 { get; set; }

    [Column("ADD5")]
    [StringLength(1)]
    [Unicode(false)]
    public string Add5 { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? City { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PinCode { get; set; }

    [Column("RCNO")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Rcno { get; set; }

    [Column("totqty", TypeName = "decimal(38, 3)")]
    public decimal? Totqty { get; set; }

    [Column("totamt", TypeName = "decimal(38, 6)")]
    public decimal? Totamt { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal RoOff { get; set; }

    [Column(TypeName = "decimal(18, 3)")]
    public decimal Invsubtot { get; set; }

    [Column("PREPARED_BY")]
    [StringLength(100)]
    [Unicode(false)]
    public string PreparedBy { get; set; } = null!;

    [Column("CHECKED_BY")]
    [StringLength(100)]
    [Unicode(false)]
    public string CheckedBy { get; set; } = null!;

    [Column("remarks")]
    [StringLength(150)]
    [Unicode(false)]
    public string Remarks { get; set; } = null!;

    [Column("DivisionUID")]
    public Guid? DivisionUid { get; set; }

    [Column("BranchUID")]
    public Guid? BranchUid { get; set; }

    [Column("TransID")]
    public Guid TransId { get; set; }
}
