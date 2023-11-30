using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 인쇄 파일 히스토리(사용안함)
/// </summary>
[MySqlCollation("utf8_unicode_ci")]
public partial class print_file_history
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    /// <summary>
    /// order_no
    /// </summary>
    [StringLength(30)]
    public string order_no { get; set; } = null!;

    /// <summary>
    /// order_item_no
    /// </summary>
    [StringLength(30)]
    public string order_item_no { get; set; } = null!;

    /// <summary>
    /// 아이템 타입
    /// </summary>
    [StringLength(20)]
    public string item_type { get; set; } = null!;

    /// <summary>
    /// 아이템 그룹
    /// </summary>
    [StringLength(5)]
    public string? item_group { get; set; }

    /// <summary>
    /// 프린트 아이템 링크
    /// </summary>
    [Column(TypeName = "text")]
    public string item_link { get; set; } = null!;

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }
}
