using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 카테고리 이미지 (사용안함)
/// </summary>
[Index("category_id", Name = "categories_images_category_id_foreign")]
[MySqlCollation("utf8_unicode_ci")]
public partial class categories_images
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    [Column(TypeName = "int(10) unsigned")]
    public uint category_id { get; set; }

    [StringLength(255)]
    public string name { get; set; } = null!;

    [StringLength(255)]
    public string? path { get; set; }

    [Column(TypeName = "int(11)")]
    public int sort_order { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }

    [ForeignKey("category_id")]
    [InverseProperty("categories_images")]
    public virtual categories category { get; set; } = null!;
}
