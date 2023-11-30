using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 상품분류
/// </summary>
[MySqlCollation("utf8_unicode_ci")]
public partial class categories
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    /// <summary>
    /// categories.id
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int parent_id { get; set; }

    /// <summary>
    /// 분류명
    /// </summary>
    [StringLength(255)]
    public string cate_name { get; set; } = null!;

    /// <summary>
    /// 분류설명
    /// </summary>
    [Column(TypeName = "text")]
    public string? desc { get; set; }

    /// <summary>
    /// 대체이미지
    /// </summary>
    [StringLength(255)]
    public string? cate_image { get; set; }

    /// <summary>
    /// 깊이
    /// </summary>
    [Column(TypeName = "tinyint(4)")]
    public sbyte? depth { get; set; }

    /// <summary>
    /// 분류꾸미기
    /// </summary>
    [Column(TypeName = "text")]
    public string? contents { get; set; }

    /// <summary>
    /// 표시상태: 0: 사용안함, 1: 사용함
    /// </summary>
    [Column(TypeName = "tinyint(4)")]
    public sbyte? use_display { get; set; }

    /// <summary>
    /// 분류꾸미기- 0:사용안함, 1:사용함
    /// </summary>
    [Column(TypeName = "tinyint(4)")]
    public sbyte? use_decorate { get; set; }

    /// <summary>
    /// 상품정렬
    /// </summary>
    [StringLength(2)]
    public string? show_sort { get; set; }

    /// <summary>
    /// 품절상품 정렬
    /// </summary>
    [StringLength(1)]
    public string? show_soldout { get; set; }

    /// <summary>
    /// 카테고리 정렬
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? sort_order { get; set; }

    /// <summary>
    /// 분류경로: 기본경로를 사용하지않을때 사용
    /// </summary>
    [StringLength(255)]
    public string? link { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }

    [InverseProperty("category")]
    public virtual ICollection<categories_images> categories_images { get; } = new List<categories_images>();
}
