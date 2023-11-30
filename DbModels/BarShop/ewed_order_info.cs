using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class ewed_order_info
{
    [Key]
    public int order_seq { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string uid { get; set; } = null!;

    public byte? order_status { get; set; }

    public byte? job_status { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isNew { get; set; }

    public int? card_seq { get; set; }

    public int? settle_price { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string order_div { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string? order_tp { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? wd_img { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? wd_file { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? output_img { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? output_swf { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? uname { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? umail { get; set; }

    [StringLength(7)]
    [Unicode(false)]
    public string? zipcode { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? address { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? addr_detail { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? phone { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? mobile { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? order_date { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? end_date { get; set; }

    public int? shop_order_seq { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? partner_div { get; set; }

    public int? order_price { get; set; }

    public int? last_total_price { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? settle_type { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? cancel_date { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? settle_date { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? settle_cancel_date { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? settle_method { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? couponseq { get; set; }

    public int? coupon_price { get; set; }

    public short? etc_price { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? etc_price_ment { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? pg_resultinfo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? pg_tid { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? pg_name { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? pg_shopid { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? job_start_date { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? job_end_date { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? job_confirm_date { get; set; }

    public byte? result_code { get; set; }

    public byte? payment_way { get; set; }

    public int? company_seq { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? auth_time { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? order_no { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? pg_cancel_date { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? cancel_reason { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? admin_id { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string isAuto { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? Daum_uid { get; set; }

    /// <summary>
    /// 미니CD주문시 e청첩장 주문 카드번호
    /// </summary>
    public int? shop_card_seq { get; set; }

    /// <summary>
    /// 미니CD주문시 e청첩장 주문 카드구문
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string? shop_order_div { get; set; }

    /// <summary>
    /// 미니CD주문시 관리자 특이사항 기재
    /// </summary>
    [StringLength(200)]
    [Unicode(false)]
    public string? minicd_adm_msg { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? bj_use { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? is_bujoo { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? bj_agency { get; set; }

    [StringLength(13)]
    [Unicode(false)]
    public string? bj_jumin { get; set; }

    [StringLength(13)]
    [Unicode(false)]
    public string? bj_hp { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? map_path { get; set; }

    public byte? ticket3 { get; set; }

    public byte? ticket5 { get; set; }

    public byte? ticket10 { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? src_erp_date { get; set; }
}
