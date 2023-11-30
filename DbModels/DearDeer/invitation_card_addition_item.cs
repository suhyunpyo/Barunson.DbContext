using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 부가상품 아이템
/// </summary>
[MySqlCollation("utf8_unicode_ci")]
public partial class invitation_card_addition_item
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    /// <summary>
    /// 부가상품 id
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int addition_id { get; set; }

    /// <summary>
    /// uploaded_image.id
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? uploaded_image_id { get; set; }

    /// <summary>
    /// 부가아이템 명
    /// </summary>
    [StringLength(50)]
    public string? item_name { get; set; }

    /// <summary>
    /// 부가아이템 명
    /// </summary>
    [StringLength(20)]
    public string? item_code { get; set; }

    /// <summary>
    /// 부가아이템 명
    /// </summary>
    [StringLength(255)]
    public string? item_desc { get; set; }

    /// <summary>
    /// 추가 금
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int item_add_price { get; set; }

    /// <summary>
    /// plus, minus, rate
    /// </summary>
    [StringLength(10)]
    public string item_add_mark { get; set; } = null!;

    /// <summary>
    /// 정렬
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
