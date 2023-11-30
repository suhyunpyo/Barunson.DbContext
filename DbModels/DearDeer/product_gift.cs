using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 사은품관리
/// </summary>
[MySqlCollation("utf8_unicode_ci")]
public partial class product_gift
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    /// <summary>
    /// 사은품명
    /// </summary>
    [StringLength(255)]
    public string name { get; set; } = null!;

    /// <summary>
    /// 사은품설명
    /// </summary>
    [StringLength(255)]
    public string? desc { get; set; }

    /// <summary>
    /// 진행상태
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int state { get; set; }

    /// <summary>
    /// 시작일
    /// </summary>
    public DateOnly? start_date { get; set; }

    /// <summary>
    /// 종료일
    /// </summary>
    public DateOnly? end_date { get; set; }

    /// <summary>
    /// 재고사용여부
    /// </summary>
    [StringLength(1)]
    public string use_stock { get; set; } = null!;

    /// <summary>
    /// 재고
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? stock { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? deleted_at { get; set; }
}
