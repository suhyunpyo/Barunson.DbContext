using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

[MySqlCollation("utf8_unicode_ci")]
public partial class hashtag
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    [Column("hashtag")]
    [StringLength(100)]
    public string? hashtag1 { get; set; }

    [StringLength(10)]
    public string? color_font { get; set; }

    /// <summary>
    /// F: 사용함, T: 사용안함
    /// </summary>
    [StringLength(1)]
    public string? is_display { get; set; }

    [Column(TypeName = "int(11)")]
    public int sort_order { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }
}
