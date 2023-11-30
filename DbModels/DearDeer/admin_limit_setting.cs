using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 초특급버튼 제한관리
/// </summary>
public partial class admin_limit_setting
{
    [Key]
    [StringLength(1)]
    public string type { get; set; } = null!;

    [Column(TypeName = "timestamp")]
    public DateTime? started_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? ended_at { get; set; }

    [StringLength(1)]
    public string? use_yn { get; set; }

    [Column(TypeName = "int(11)")]
    public int? owner_id { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }
}
