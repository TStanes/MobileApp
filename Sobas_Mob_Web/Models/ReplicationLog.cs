using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob_Web.Models;

[Table("ReplicationLog")]
public partial class ReplicationLog
{
    [Key]
    public int SlNo { get; set; }

    [Column("DBName")]
    [StringLength(50)]
    [Unicode(false)]
    public string Dbname { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string TableName { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime LogCreatedDate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime LogModifiedDate { get; set; }
}
