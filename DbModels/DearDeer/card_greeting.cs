using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 인사말
/// </summary>
[MySqlCollation("utf8_unicode_ci")]
public partial class card_greeting
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    /// <summary>
    /// 제목
    /// </summary>
    [StringLength(100)]
    public string? name { get; set; }

    /// <summary>
    /// 작성자
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int owner_id { get; set; }

    /// <summary>
    /// 수정한사람
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int updater_id { get; set; }

    /// <summary>
    /// 카테고리1
    /// </summary>
    [StringLength(100)]
    public string? category1 { get; set; }

    /// <summary>
    /// 카테고리2
    /// </summary>
    [StringLength(100)]
    public string? category2 { get; set; }

    /// <summary>
    /// 인사말
    /// </summary>
    [Column(TypeName = "text")]
    public string? contents { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }
}
