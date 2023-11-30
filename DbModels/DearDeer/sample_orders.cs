using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 샘플주문
/// </summary>
[Index("sample_order_no", Name = "sample_order_no")]
[Index("user_id", Name = "user_id")]
[MySqlCollation("utf8_unicode_ci")]
public partial class sample_orders
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    /// <summary>
    /// 주문번호
    /// </summary>
    [StringLength(30)]
    public string sample_order_no { get; set; } = null!;

    /// <summary>
    /// users.id
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int user_id { get; set; }

    /// <summary>
    /// addresses.id
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int addresses_id { get; set; }

    /// <summary>
    /// partner_shop.id
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int partner_shop_id { get; set; }

    /// <summary>
    /// 신랑 성
    /// </summary>
    [StringLength(20)]
    public string? groom_fname { get; set; }

    /// <summary>
    /// 신랑 이름
    /// </summary>
    [StringLength(20)]
    public string? groom_name { get; set; }

    /// <summary>
    /// 신랑 영문 이름
    /// </summary>
    [StringLength(20)]
    public string? groom_fname_eng { get; set; }

    /// <summary>
    /// 신랑 영문성
    /// </summary>
    [StringLength(20)]
    public string? groom_name_eng { get; set; }

    /// <summary>
    /// 신부 성
    /// </summary>
    [StringLength(20)]
    public string? bride_fname { get; set; }

    /// <summary>
    /// 신부 이름
    /// </summary>
    [StringLength(20)]
    public string? bride_name { get; set; }

    /// <summary>
    /// 신부 영문 이름
    /// </summary>
    [StringLength(20)]
    public string? bride_fname_eng { get; set; }

    /// <summary>
    /// 신부 영문성
    /// </summary>
    [StringLength(20)]
    public string? bride_name_eng { get; set; }

    /// <summary>
    /// 예식일
    /// </summary>
    [StringLength(50)]
    public string? wedd_date { get; set; }

    /// <summary>
    /// 배송상태
    /// </summary>
    [StringLength(2)]
    public string shipping_state { get; set; } = null!;

    /// <summary>
    /// 제작상태
    /// </summary>
    [StringLength(2)]
    public string printing_state { get; set; } = null!;

    /// <summary>
    /// 주문상태
    /// </summary>
    [StringLength(2)]
    public string order_state { get; set; } = null!;

    /// <summary>
    /// 송장번호
    /// </summary>
    [StringLength(50)]
    public string? shipping_num { get; set; }

    /// <summary>
    /// 배송사
    /// </summary>
    [StringLength(50)]
    public string? shipping_company { get; set; }

    /// <summary>
    /// 샘플발송일
    /// </summary>
    [Column(TypeName = "timestamp")]
    public DateTime? shipping_at { get; set; }

    /// <summary>
    /// custom_samlpe_order.samlpq_order_seq
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? barunson_order_seq { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? deleted_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? cancel_at { get; set; }

    /// <summary>
    /// 메모
    /// </summary>
    [Column(TypeName = "text")]
    public string? memo { get; set; }

    /// <summary>
    /// 전체금액
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? total_money { get; set; }

    /// <summary>
    /// 전체금액
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? paid_money { get; set; }

    [Column(TypeName = "int(11)")]
    public int? cash_request { get; set; }

    /// <summary>
    /// 무통장입금
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? cash { get; set; }

    /// <summary>
    /// 결제 타입
    /// </summary>
    [StringLength(255)]
    public string? pay_type { get; set; }

    /// <summary>
    /// 결제회사명
    /// </summary>
    [StringLength(255)]
    public string? pg_name { get; set; }

    /// <summary>
    /// 결제 회사 tid
    /// </summary>
    [StringLength(255)]
    public string? pg_tno { get; set; }

    /// <summary>
    /// 결제 앱 번호
    /// </summary>
    [StringLength(255)]
    public string? pg_app_no { get; set; }

    /// <summary>
    /// 은행명
    /// </summary>
    [StringLength(255)]
    public string? bank_info { get; set; }

    /// <summary>
    /// 은행명
    /// </summary>
    [StringLength(255)]
    public string? bank_name { get; set; }

    /// <summary>
    /// 관리자 메모
    /// </summary>
    [Column(TypeName = "text")]
    public string? admin_memo { get; set; }

    /// <summary>
    /// 결제 일자
    /// </summary>
    [StringLength(14)]
    public string? pay_date { get; set; }

    /// <summary>
    /// 결제 년
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? pay_year { get; set; }

    /// <summary>
    /// 결제 월
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? pay_month { get; set; }

    /// <summary>
    /// 결제 일
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? pay_day { get; set; }

    /// <summary>
    /// 주문자 ip
    /// </summary>
    [StringLength(20)]
    public string? order_ip { get; set; }

    /// <summary>
    /// 주문자 useragent
    /// </summary>
    [StringLength(255)]
    public string? order_useragent { get; set; }

    [StringLength(4000)]
    public string? service_memo { get; set; }

    /// <summary>
    /// F U+ 주문취소가능 / T 취소불가 
    /// </summary>
    [StringLength(1)]
    public string is_create_file { get; set; } = null!;

    /// <summary>
    /// 환불일자
    /// </summary>
    [Column(TypeName = "timestamp")]
    public DateTime? refunded_at { get; set; }

    /// <summary>
    /// 환불타입 - A: 부분환불, B:전체환불
    /// </summary>
    [StringLength(1)]
    public string? refund_type { get; set; }

    /// <summary>
    /// 환불금액
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? refund_money { get; set; }

    /// <summary>
    /// payment||fail
    /// </summary>
    [StringLength(20)]
    public string order_step { get; set; } = null!;

    /// <summary>
    /// lguplus_paid_list.id
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? paid_list_id { get; set; }
}
