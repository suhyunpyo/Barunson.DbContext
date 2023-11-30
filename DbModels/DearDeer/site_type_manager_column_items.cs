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
public partial class site_type_manager_column_items
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    /// <summary>
    /// site_type_manager.id
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? site_type_manager_id { get; set; }

    /// <summary>
    /// site_type_manager_column.id
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? site_type_manager_column_id { get; set; }

    /// <summary>
    /// 아이템 라벨
    /// </summary>
    [StringLength(30)]
    public string? item_label { get; set; }

    /// <summary>
    /// 아이템 값
    /// </summary>
    [StringLength(30)]
    public string? item_value { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? deleted_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }
}
