using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("AccountTypeM")]
public partial class AccountTypeM
{
    public int AccountType { get; set; }

    [StringLength(9)]
    [Unicode(false)]
    public string AccountTypeDesc { get; set; } = null!;
}
