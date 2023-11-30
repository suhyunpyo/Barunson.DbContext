using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

[MySqlCollation("utf8_unicode_ci")]
public partial class board_content_attached
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    /// <summary>
    /// board.id
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int board_id { get; set; }

    /// <summary>
    /// board_contents.id
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int board_contents_id { get; set; }

    /// <summary>
    /// url
    /// </summary>
    [StringLength(255)]
    public string? path { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }
}
