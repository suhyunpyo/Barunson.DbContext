using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 무통장입금내역
/// </summary>
[Index("order_id", Name = "order_id")]
[Index("order_no", Name = "order_no")]
[MySqlCollation("utf8_unicode_ci")]
public partial class order_deposits
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
    /// orders.user_id
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int user_id { get; set; }

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
    /// 입금자
    /// </summary>
    [StringLength(20)]
    public string? bank_name { get; set; }

    /// <summary>
    /// 입금금액
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? deposit_money { get; set; }

    /// <summary>
    /// 입금진행상황 - B: 입금전, E: 입금완료, C:금액변경, X:입금취소
    /// </summary>
    [StringLength(1)]
    public string? deposit_progress { get; set; }

    /// <summary>
    /// 입금 내용
    /// </summary>
    [Column(TypeName = "text")]
    public string? deposit_memo { get; set; }

    /// <summary>
    /// 비고
    /// </summary>
    [Column(TypeName = "text")]
    public string? etc_memo { get; set; }

    /// <summary>
    /// 입금일
    /// </summary>
    [Column(TypeName = "timestamp")]
    public DateTime? deposit_date { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? deleted_at { get; set; }
}
