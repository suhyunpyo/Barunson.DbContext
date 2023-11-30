using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// faq 게시판
/// </summary>
[MySqlCollation("utf8_unicode_ci")]
public partial class faq_boards
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    /// <summary>
    /// 이벤트 명
    /// </summary>
    [StringLength(255)]
    public string board_name { get; set; } = null!;

    /// <summary>
    /// 순번
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int sort_order { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? deleted_at { get; set; }
}
