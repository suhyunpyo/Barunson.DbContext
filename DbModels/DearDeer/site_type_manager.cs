using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 타입메니져(사용안함)
/// </summary>
[MySqlCollation("utf8_unicode_ci")]
public partial class site_type_manager
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    /// <summary>
    /// 테이블 라벨
    /// </summary>
    [StringLength(30)]
    public string? manage_label { get; set; }

    /// <summary>
    /// 테이블 명
    /// </summary>
    [StringLength(30)]
    public string? manage_name { get; set; }

    /// <summary>
    /// 생성자  users.id
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? owner_id { get; set; }

    /// <summary>
    /// 업데이트  users.id
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? updater_id { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? deleted_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }
}
