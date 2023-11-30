using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 영상 주문 이미지(사용안함)
/// </summary>
[MySqlCollation("utf8_unicode_ci")]
public partial class movie_order_images
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    [Column(TypeName = "int(11)")]
    public int? movie_order_id { get; set; }

    [StringLength(30)]
    public string? order_no { get; set; }

    /// <summary>
    /// order_item.order_item_no
    /// </summary>
    [StringLength(30)]
    public string? order_item_no { get; set; }

    /// <summary>
    /// 사진 위치
    /// </summary>
    [StringLength(255)]
    public string? file_path { get; set; }

    [StringLength(255)]
    public string? thumbnail { get; set; }

    [StringLength(10)]
    public string? group { get; set; }

    /// <summary>
    /// zip파일로 만들었니??
    /// </summary>
    [StringLength(1)]
    public string is_zip { get; set; } = null!;

    [Column(TypeName = "int(11)")]
    public int? sort_order { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? deleted_at { get; set; }
}
