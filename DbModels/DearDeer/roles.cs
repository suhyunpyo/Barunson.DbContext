using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 권한관리
/// </summary>
[MySqlCollation("utf8_unicode_ci")]
public partial class roles
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    [StringLength(255)]
    public string name { get; set; } = null!;

    [StringLength(255)]
    public string description { get; set; } = null!;

    [Column(TypeName = "tinyint(3) unsigned")]
    public byte type { get; set; }
}
