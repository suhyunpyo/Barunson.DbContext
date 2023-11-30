using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

[Index("queue", Name = "jobs_queue_index")]
[MySqlCollation("utf8_unicode_ci")]
public partial class jobs
{
    [Key]
    [Column(TypeName = "bigint(20) unsigned")]
    public ulong id { get; set; }

    [StringLength(255)]
    public string queue { get; set; } = null!;

    public string payload { get; set; } = null!;

    [Column(TypeName = "tinyint(3) unsigned")]
    public byte attempts { get; set; }

    [Column(TypeName = "int(10) unsigned")]
    public uint? reserved_at { get; set; }

    [Column(TypeName = "int(10) unsigned")]
    public uint available_at { get; set; }

    [Column(TypeName = "int(10) unsigned")]
    public uint created_at { get; set; }
}
