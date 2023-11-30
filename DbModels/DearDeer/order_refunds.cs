using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 환불정보
/// </summary>
[Index("order_id", Name = "order_id")]
[Index("order_no", Name = "order_no")]
[MySqlCollation("utf8_unicode_ci")]
public partial class order_refunds
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    /// <summary>
    /// 남긴사람
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? owner_id { get; set; }

    /// <summary>
    /// orders.id
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int order_id { get; set; }

    /// <summary>
    /// orders.order_no
    /// </summary>
    [StringLength(30)]
    public string order_no { get; set; } = null!;

    /// <summary>
    /// 환불은행
    /// </summary>
    [StringLength(10)]
    public string? refund_back_name { get; set; }

    /// <summary>
    /// 환불계좌
    /// </summary>
    [StringLength(20)]
    public string? refund_back_number { get; set; }

    /// <summary>
    /// 예금주
    /// </summary>
    [StringLength(20)]
    public string? refund_back_account { get; set; }

    /// <summary>
    /// 환불금액
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? refund_money { get; set; }

    /// <summary>
    /// 환불타입 - A: 부분환불, B:전체환불
    /// </summary>
    [StringLength(1)]
    public string? refund_type { get; set; }

    /// <summary>
    /// 환불방법 - A: 무통장입금, B: 카드취소
    /// </summary>
    [StringLength(1)]
    public string? refund_method { get; set; }

    /// <summary>
    /// 환불 사유메모
    /// </summary>
    [Column(TypeName = "text")]
    public string? refund_memo { get; set; }

    /// <summary>
    /// 환분진행상황 - B: 환불요청, R: 환불예정, E:환불완료, X:환불취소
    /// </summary>
    [StringLength(1)]
    public string? refund_progress { get; set; }

    /// <summary>
    /// 환불 취소 사유
    /// </summary>
    [Column(TypeName = "text")]
    public string? refund_cancel_memo { get; set; }

    /// <summary>
    /// 환불예정일
    /// </summary>
    public DateOnly? refund_due_date { get; set; }

    /// <summary>
    /// 환불일자
    /// </summary>
    [Column(TypeName = "timestamp")]
    public DateTime? refunded_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? deleted_at { get; set; }
}
