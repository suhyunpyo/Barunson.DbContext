using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 옵션
/// </summary>
[Index("option_style", Name = "option_style")]
[MySqlCollation("utf8_unicode_ci")]
public partial class options
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    [StringLength(255)]
    public string name { get; set; } = null!;

    [StringLength(255)]
    public string show_name { get; set; } = null!;

    [Column(TypeName = "text")]
    public string? desc { get; set; }

    [StringLength(50)]
    public string? code { get; set; }

    [StringLength(50)]
    public string? option_type { get; set; }

    [StringLength(50)]
    public string? option_style { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? deleted_at { get; set; }

    [InverseProperty("option")]
    public virtual ICollection<options_items> options_items { get; } = new List<options_items>();
}
