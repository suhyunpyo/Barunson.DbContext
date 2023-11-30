using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 초안수정히스토리(사용안함)
/// </summary>
[Index("order_item_no", Name = "order_item_no")]
[MySqlCollation("utf8_unicode_ci")]
public partial class draft_history
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    /// <summary>
    /// order_items.order_item_no
    /// </summary>
    [StringLength(30)]
    public string order_item_no { get; set; } = null!;

    /// <summary>
    /// 초안 링크
    /// </summary>
    [Column(TypeName = "text")]
    public string draft_link { get; set; } = null!;

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
