using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("CountryM")]
public partial class CountryM
{
    [Key]
    [Column("CountryUID")]
    public Guid CountryUid { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string CountryCode { get; set; } = null!;

    [StringLength(150)]
    [Unicode(false)]
    public string CountryName { get; set; } = null!;

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

    [InverseProperty("CountryU")]
    public virtual ICollection<CountryItemRate> CountryItemRates { get; set; } = new List<CountryItemRate>();

    [InverseProperty("CountryU")]
    public virtual ICollection<DiscountMappingCountry> DiscountMappingCountries { get; set; } = new List<DiscountMappingCountry>();

    [InverseProperty("CountryU")]
    public virtual ICollection<PartyM> PartyMs { get; set; } = new List<PartyM>();

    [InverseProperty("CountryU")]
    public virtual ICollection<SecondarySupplierM> SecondarySupplierMs { get; set; } = new List<SecondarySupplierM>();
}
