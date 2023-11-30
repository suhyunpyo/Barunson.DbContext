using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 환불 관련
/// </summary>
public partial class custom_order_refund
{
    [Key]
    public int id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? order_tbl { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? sales_gubun { get; set; }

    public int? company_seq { get; set; }

    public long order_seq { get; set; }

    /// <summary>
    /// 주문자명
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string? order_name { get; set; }

    /// <summary>
    /// 결제일
    /// </summary>
    [StringLength(10)]
    [Unicode(false)]
    public string? settle_date { get; set; }

    /// <summary>
    /// 결제방법 (1:계좌이체,3:무통장,2,6:카드)
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string? settle_method { get; set; }

    /// <summary>
    /// 결제금액
    /// </summary>
    public int? settle_price { get; set; }

    /// <summary>
    /// 환물은행명
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string? bank_name { get; set; }

    /// <summary>
    /// 환불은행계좌
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string? bank_account { get; set; }

    /// <summary>
    /// 환불은행 예금주
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string? bank_user { get; set; }

    /// <summary>
    /// 환불금액
    /// </summary>
    public int refund_price { get; set; }

    /// <summary>
    /// 환불일
    /// </summary>
    [StringLength(10)]
    [Unicode(false)]
    public string? refund_date { get; set; }

    /// <summary>
    /// 메모
    /// </summary>
    [StringLength(2000)]
    [Unicode(false)]
    public string? refund_msg { get; set; }

    /// <summary>
    /// 환불 유형
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string? refund_gubun { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string admin_id { get; set; } = null!;

    /// <summary>
    /// 환불세부유형 manage_code.code
    /// </summary>
    [StringLength(200)]
    public string? REFUND_TYPE_CODE { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime reg_date { get; set; }
}
