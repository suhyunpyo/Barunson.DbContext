using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 차단관리
/// </summary>
[Index("check_ip", Name = "check_ip")]
[Index("block_type", "check_type", "deleted_at", Name = "idx_2")]
[MySqlCollation("utf8_unicode_ci")]
public partial class block_manager
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    /// <summary>
    /// A:전체/U:특정 URL
    /// </summary>
    [StringLength(1)]
    public string block_type { get; set; } = null!;

    /// <summary>
    /// P:IP/D:ID
    /// </summary>
    [StringLength(1)]
    public string check_type { get; set; } = null!;

    /// <summary>
    /// IP 혹은 ID
    /// </summary>
    [StringLength(50)]
    public string? check_ip { get; set; }

    /// <summary>
    /// 차단된 users.id
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? user_id { get; set; }

    /// <summary>
    /// 작성자 users.id
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? updater_id { get; set; }

    /// <summary>
    /// 블럭 주소
    /// </summary>
    [StringLength(50)]
    public string? block_url { get; set; }

    /// <summary>
    /// 블럭사유
    /// </summary>
    [StringLength(50)]
    public string? memo { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? deleted_at { get; set; }
}
