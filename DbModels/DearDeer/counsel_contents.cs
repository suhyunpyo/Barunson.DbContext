using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 고객상담 내용
/// </summary>
[Index("user_id", Name = "user_id")]
[MySqlCollation("utf8_unicode_ci")]
public partial class counsel_contents
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    /// <summary>
    /// 상담 작성자 id
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? manager { get; set; }

    /// <summary>
    /// 상담 고객
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? user_id { get; set; }

    /// <summary>
    /// 상담 내용
    /// </summary>
    [Column(TypeName = "text")]
    public string? contents { get; set; }

    /// <summary>
    /// 긴급 요청
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? urgent { get; set; }

    /// <summary>
    /// 확인 유무
    /// </summary>
    [Column("checked", TypeName = "int(11)")]
    public int? _checked { get; set; }

    /// <summary>
    /// 확인한 사람
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? checked_manager { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? deleted_at { get; set; }
}
