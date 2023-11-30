using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 인디자인 생성 히스토리(사용안함)
/// </summary>
[MySqlCollation("utf8_unicode_ci")]
public partial class indd_create_history
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    /// <summary>
    /// order_items.order_item_no
    /// </summary>
    [StringLength(50)]
    public string order_item_no { get; set; } = null!;

    /// <summary>
    /// indd 링크
    /// </summary>
    [Column(TypeName = "text")]
    public string indd_link { get; set; } = null!;

    /// <summary>
    /// 변경된 indd 파일 링크
    /// </summary>
    [Column(TypeName = "text")]
    public string? changed_indd_link { get; set; }

    [StringLength(1)]
    public string? is_custom { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }
}
