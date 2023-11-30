using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 재고관리(사용안함)
/// </summary>
[MySqlCollation("utf8_unicode_ci")]
public partial class item_stock_manage
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    /// <summary>
    /// 아이템코드
    /// </summary>
    [StringLength(30)]
    public string? stock_code { get; set; }

    /// <summary>
    /// I:장당/P:종이
    /// </summary>
    [StringLength(1)]
    public string stock_type { get; set; } = null!;

    /// <summary>
    /// 차감수량: 전지 6개 1장이면 6
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int item_per { get; set; }

    /// <summary>
    /// 누적수량
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int incremental_qty { get; set; }

    /// <summary>
    /// 재고 사용
    /// </summary>
    [StringLength(1)]
    public string use_stock { get; set; } = null!;

    /// <summary>
    /// 안전재고사용
    /// </summary>
    [StringLength(1)]
    public string use_safety { get; set; } = null!;

    /// <summary>
    /// 재고수량
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int stock_qty { get; set; }

    /// <summary>
    /// 안전재고수량
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int safety_qty { get; set; }

    /// <summary>
    /// 샘플 재고 사용
    /// </summary>
    [StringLength(1)]
    public string use_sample_stock { get; set; } = null!;

    /// <summary>
    /// 샘플 안전재고사용
    /// </summary>
    [StringLength(1)]
    public string use_sample_safety { get; set; } = null!;

    /// <summary>
    /// 샘플 재고수량
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int sample_stock_qty { get; set; }

    /// <summary>
    /// 샘플 안전재고수량
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int sample_safety_qty { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? deleted_at { get; set; }
}
