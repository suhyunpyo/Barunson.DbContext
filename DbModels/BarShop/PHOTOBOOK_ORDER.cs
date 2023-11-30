using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class PHOTOBOOK_ORDER
{
    [Key]
    public int id { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string site_code { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string? sales_gubun { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? member_id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? order_name { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? order_email { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? order_phone { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? order_hphone { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? recv_name { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? recv_phone { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? recv_hphone { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? recv_zip { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? recv_addr { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? recv_addr_detail { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? recv_msg { get; set; }

    public byte? status_seq { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? order_date { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? order_time { get; set; }

    public int? order_price { get; set; }

    public int? point_price { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? discount_type { get; set; }

    public short? discount_rate { get; set; }

    public int? reduce_price { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? coupon_code { get; set; }

    public int? coupon_price { get; set; }

    public int? delivery_price { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? delivery_code { get; set; }

    public int? total_price { get; set; }

    public int? settle_price { get; set; }

    /// <summary>
    /// 1:정상,4:사고건
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string pay_type { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? employer_name { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? settle_date { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? cancel_date { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? cancel_admin_id { get; set; }

    public int? worder_id { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? worder_gubun { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? settle_method { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? pg_resultinfo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? pg_resultinfo2 { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? pg_shopid { get; set; }

    public int? pg_fee { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? pg_tid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? dacom_tid { get; set; }

    /// <summary>
    /// 할부개월수
    /// </summary>
    [StringLength(2)]
    [Unicode(false)]
    public string? card_installmonth { get; set; }

    /// <summary>
    /// 무이자할부여부
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string? card_nointyn { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isReceipt { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isSystemUpdate { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string isBalju { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string? isOpen { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? balju_date { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? merge_date { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? entering_date { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? packing_date { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? delivery_date { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? admin_memo { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? request_date { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? src_erp_date { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ip { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? delivery_com { get; set; }
}
