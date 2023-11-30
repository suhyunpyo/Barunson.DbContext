using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// (사용안함)
/// </summary>
[MySqlCollation("utf8_unicode_ci")]
public partial class draft_history_comment
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
    /// draft_history.id
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int draft_history_id { get; set; }

    /// <summary>
    /// 코멘트 타입
    /// </summary>
    [StringLength(5)]
    public string? comment_type { get; set; }

    /// <summary>
    /// 코멘트트
    /// </summary>
    [Column(TypeName = "text")]
    public string comment { get; set; } = null!;

    /// <summary>
    /// 첨부파일
    /// </summary>
    [StringLength(255)]
    public string? attached { get; set; }

    /// <summary>
    /// 초안 확정 상태
    /// </summary>
    [StringLength(2)]
    public string draft_state { get; set; } = null!;

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }
}
