using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

[MySqlCollation("utf8_unicode_ci")]
public partial class order_item_detail
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    /// <summary>
    /// 오더 id
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int order_id { get; set; }

    /// <summary>
    /// 오더 아이템 id
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int order_item_id { get; set; }

    /// <summary>
    /// 오더 아이템 디테일 id
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int order_item_detail_no { get; set; }

    /// <summary>
    /// CD:카드, EP:봉투, SK:스티커, SR:스테이셔너리, TK:티켓, ETC:일반
    /// </summary>
    [StringLength(255)]
    public string detail_type { get; set; } = null!;

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }
}
