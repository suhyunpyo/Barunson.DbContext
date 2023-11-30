using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 주문
/// </summary>
[Index("barunson_order_seq", Name = "idx_orders_barunson_order_seq")]
[Index("order_no", Name = "order_no")]
[Index("user_id", Name = "user_id")]
[Index("order_base", "user_id", Name = "user_id_order_base")]
[MySqlCollation("utf8_unicode_ci")]
public partial class orders
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    [StringLength(30)]
    public string order_no { get; set; } = null!;

    /// <summary>
    /// wcard, goods, mcard
    /// </summary>
    [StringLength(20)]
    public string order_base { get; set; } = null!;

    /// <summary>
    /// red, barunson
    /// </summary>
    [StringLength(10)]
    public string base_printing_company { get; set; } = null!;

    [Column(TypeName = "int(11)")]
    public int user_id { get; set; }

    [Column(TypeName = "int(11)")]
    public int admin_id { get; set; }

    [Column(TypeName = "int(11)")]
    public int paid_list_id { get; set; }

    [Column(TypeName = "int(11)")]
    public int addresses_id { get; set; }

    /// <summary>
    /// partner_shop.id
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int partner_shop_id { get; set; }

    [Column(TypeName = "int(11)")]
    public int order_card_base_id { get; set; }

    [Column(TypeName = "text")]
    public string? memo { get; set; }

    [Column(TypeName = "int(11)")]
    public int? total_money { get; set; }

    [Column(TypeName = "int(11)")]
    public int? paid_money { get; set; }

    [Column(TypeName = "int(11)")]
    public int? deposit { get; set; }

    [Column(TypeName = "int(11)")]
    public int? cash_request { get; set; }

    [Column(TypeName = "int(11)")]
    public int? cash { get; set; }

    [Column(TypeName = "text")]
    public string? content { get; set; }

    [StringLength(10)]
    public string? pay_type { get; set; }

    [StringLength(20)]
    public string? pg_name { get; set; }

    [StringLength(200)]
    public string? pg_tno { get; set; }

    [StringLength(20)]
    public string? pg_app_no { get; set; }

    [StringLength(50)]
    public string? bank_info { get; set; }

    [StringLength(50)]
    public string? bank_name { get; set; }

    [Column(TypeName = "text")]
    public string? admin_memo { get; set; }

    [StringLength(14)]
    public string? pay_date { get; set; }

    [Column(TypeName = "int(11)")]
    public int? pay_year { get; set; }

    [Column(TypeName = "int(11)")]
    public int? pay_month { get; set; }

    [Column(TypeName = "int(11)")]
    public int? pay_day { get; set; }

    [StringLength(20)]
    public string? approve_datetime { get; set; }

    [StringLength(20)]
    public string? order_ip { get; set; }

    [StringLength(50)]
    public string? order_useragent { get; set; }

    [StringLength(3)]
    public string order_state { get; set; } = null!;

    [StringLength(3)]
    public string shipping_state { get; set; } = null!;

    [StringLength(3)]
    public string printing_state { get; set; } = null!;

    [StringLength(3)]
    public string draft_state { get; set; } = null!;

    /// <summary>
    /// 주문 타입 : D=일반, Q:빠른
    /// </summary>
    [StringLength(1)]
    public string? order_type { get; set; }

    [StringLength(20)]
    public string? shipping_company { get; set; }

    [StringLength(20)]
    public string? shipping_number { get; set; }

    [StringLength(255)]
    public string? shipping_memo { get; set; }

    [StringLength(100)]
    public string? draft_link { get; set; }

    [StringLength(100)]
    public string? printing_link { get; set; }

    [StringLength(100)]
    public string? indd_link { get; set; }

    [StringLength(20)]
    public string? order_step { get; set; }

    [StringLength(1)]
    public string? use_coupon { get; set; }

    [StringLength(1)]
    public string? is_create_file { get; set; }

    [StringLength(1)]
    public string? is_printing { get; set; }

    [StringLength(1)]
    public string is_accident { get; set; } = null!;

    /// <summary>
    /// 패킹상태 : B:시작전,  S:시작,  E:완료
    /// </summary>
    [StringLength(1)]
    public string packing_state { get; set; } = null!;

    [Column(TypeName = "int(11)")]
    public int? accident_order_id { get; set; }

    /// <summary>
    /// 사고건 이미지
    /// </summary>
    [StringLength(100)]
    public string? accident_image { get; set; }

    [StringLength(50)]
    public string? red_api_state { get; set; }

    [StringLength(10)]
    public string? red_order_date { get; set; }

    [StringLength(10)]
    public string? status_red { get; set; }

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
    /// 환불일자
    /// </summary>
    [Column(TypeName = "timestamp")]
    public DateTime? refunded_at { get; set; }

    /// <summary>
    /// 인쇄차수
    /// </summary>
    [StringLength(10)]
    public string? print_degree { get; set; }

    /// <summary>
    /// 요금단위
    /// </summary>
    [StringLength(10)]
    public string charge_unit { get; set; } = null!;

    /// <summary>
    /// 부피단위
    /// </summary>
    [StringLength(10)]
    public string volumne_unit { get; set; } = null!;

    /// <summary>
    /// 박스단위
    /// </summary>
    [StringLength(10)]
    public string box_unit { get; set; } = null!;

    /// <summary>
    /// 사물함번호
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? locker_no { get; set; }

    /// <summary>
    /// 레드주문번호
    /// </summary>
    [StringLength(20)]
    public string? red_order_no { get; set; }

    [Column(TypeName = "int(11)")]
    public int? barunson_order_seq { get; set; }

    /// <summary>
    /// 바른손 주문타입: base: 인쇄제품, etc: 완제품
    /// </summary>
    [StringLength(5)]
    public string barunson_order_type { get; set; } = null!;

    /// <summary>
    /// 바른손에 주문성공: T, 실패: F
    /// </summary>
    [StringLength(1)]
    public string barunson_order_flag { get; set; } = null!;

    /// <summary>
    /// 바른손 주문상태값
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int barunson_status_seq { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? draft_start { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? draft_end { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? draft_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? printing_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? shipping_at { get; set; }

    /// <summary>
    /// 패킹시작시간
    /// </summary>
    [Column(TypeName = "timestamp")]
    public DateTime? packing_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? deleted_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? cancel_at { get; set; }

    /// <summary>
    /// 배송타입 : P=택배, D=직접, Q:퀵, 
    /// </summary>
    [StringLength(1)]
    public string? shipping_type { get; set; }

    /// <summary>
    /// 할인 금액
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int discount_money { get; set; }

    /// <summary>
    /// 원금 합계
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int original_amount { get; set; }

    /// <summary>
    /// 배송예정일
    /// </summary>
    public DateOnly? shipping_due_date { get; set; }

    [StringLength(4000)]
    public string? service_memo { get; set; }

    /// <summary>
    /// 배송비
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int delivery_price { get; set; }
}
