using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sobas_Mob.Models;

[Keyless]
[Table("TableCMRecordCount")]
public partial class TableCmrecordCount
{
    [Column("DBName")]
    [StringLength(4)]
    [Unicode(false)]
    public string Dbname { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string Tablename { get; set; } = null!;

    [Column("CCount")]
    public int Ccount { get; set; }

    [Column("MCount")]
    public int Mcount { get; set; }

    [Column("CLastDate", TypeName = "datetime")]
    public DateTime ClastDate { get; set; }

    [Column("MLastDate", TypeName = "datetime")]
    public DateTime MlastDate { get; set; }

    [Column("DTType")]
    public byte? Dttype { get; set; }
}
