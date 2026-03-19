using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("StateM")]
public partial class StateM1
{
    [Key]
    [Column("StateUID")]
    public Guid StateUid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string StateCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string StateDesc { get; set; } = null!;

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

    [InverseProperty("StateU")]
    public virtual ICollection<DiscountMappingState> DiscountMappingStates { get; set; } = new List<DiscountMappingState>();

    [InverseProperty("StateU")]
    public virtual ICollection<PartyM> PartyMs { get; set; } = new List<PartyM>();

    [InverseProperty("StateU")]
    public virtual ICollection<RegistrationM> RegistrationMs { get; set; } = new List<RegistrationM>();

    [InverseProperty("StateU")]
    public virtual ICollection<SecondarySupplierM> SecondarySupplierMs { get; set; } = new List<SecondarySupplierM>();

    [InverseProperty("StateU")]
    public virtual ICollection<StateCommodityM> StateCommodityMs { get; set; } = new List<StateCommodityM>();

    [InverseProperty("StateU")]
    public virtual ICollection<StateItemRate> StateItemRates { get; set; } = new List<StateItemRate>();

    [InverseProperty("StateU")]
    public virtual ICollection<TaxM> TaxMs { get; set; } = new List<TaxM>();
}
