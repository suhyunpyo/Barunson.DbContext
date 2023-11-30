using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 주문번호 시퀀스
/// </summary>
[Index("order_no", Name = "order_no")]
[MySqlCollation("utf8_unicode_ci")]
public partial class order_seq_autoinc
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    [Column(TypeName = "int(10) unsigned")]
    public uint user_id { get; set; }

    [StringLength(4)]
    public string? type { get; set; }

    /// <summary>
    /// 기기정보
    /// </summary>
    [StringLength(30)]
    public string? device { get; set; }

    /// <summary>
    /// 브라우져
    /// </summary>
    [StringLength(30)]
    public string? browser { get; set; }

    /// <summary>
    /// 브라우져 버전
    /// </summary>
    [StringLength(30)]
    public string? browser_ver { get; set; }

    /// <summary>
    /// 운영체제
    /// </summary>
    [StringLength(30)]
    public string? platform { get; set; }

    /// <summary>
    /// 운영체제 버전
    /// </summary>
    [StringLength(20)]
    public string? platform_ver { get; set; }

    /// <summary>
    /// orders.order_no
    /// </summary>
    [StringLength(21)]
    public string? order_no { get; set; }

    /// <summary>
    /// 모바일 주문 여부
    /// </summary>
    [Column(TypeName = "tinyint(4)")]
    public sbyte is_mobile { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }
}
