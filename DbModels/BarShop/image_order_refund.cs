using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 이미지_주문_환불
/// </summary>
public partial class image_order_refund
{
    /// <summary>
    /// 환불_고유번호
    /// </summary>
    [Key]
    public int io_refund_seq { get; set; }

    /// <summary>
    /// 이미지_주문_고유번호
    /// </summary>
    public int? io_seq { get; set; }

    /// <summary>
    /// 환불_유형
    /// </summary>
    public byte? refund_type { get; set; }

    /// <summary>
    /// 환불_금액
    /// </summary>
    public int? refund_price { get; set; }

    /// <summary>
    /// 은행
    /// </summary>
    [StringLength(50)]
    public string? bank_name { get; set; }

    /// <summary>
    /// 계좌번호
    /// </summary>
    [StringLength(25)]
    [Unicode(false)]
    public string? bank_account_no { get; set; }

    /// <summary>
    /// 예금주
    /// </summary>
    [StringLength(50)]
    public string? bank_account_name { get; set; }

    /// <summary>
    /// 요청_일시
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? refund_request_date { get; set; }

    /// <summary>
    /// 요청자_ID
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string? refund_request_id { get; set; }

    /// <summary>
    /// 요청자_구분
    /// </summary>
    public byte? refund_request_type { get; set; }

    /// <summary>
    /// 처리_일시
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? refund_proceed_date { get; set; }

    /// <summary>
    /// 처리자_ID
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string? refund_proceed_id { get; set; }

    /// <summary>
    /// 처리자_구분
    /// </summary>
    public byte? refund_proceed_type { get; set; }
}
