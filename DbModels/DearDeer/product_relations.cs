using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 관련상품(컬러옵션)
/// </summary>
[MySqlCollation("utf8_unicode_ci")]
public partial class product_relations
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    /// <summary>
    /// products.id
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int product_id { get; set; }

    /// <summary>
    /// 연결상품 products.id
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int child_product_id { get; set; }

    /// <summary>
    /// 연관상품 컬러
    /// </summary>
    [StringLength(7)]
    public string? child_color { get; set; }

    /// <summary>
    /// 연관상품 타이틀
    /// </summary>
    [StringLength(50)]
    public string? child_title { get; set; }

    [StringLength(255)]
    public string? child_desc { get; set; }

    /// <summary>
    /// 표시방식
    /// </summary>
    [StringLength(2)]
    public string? child_display_type { get; set; }

    /// <summary>
    /// 추가금액
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int child_add_price { get; set; }

    /// <summary>
    /// 표시순서
    /// </summary>
    [Column(TypeName = "tinyint(4)")]
    public sbyte sort_order { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }
}
