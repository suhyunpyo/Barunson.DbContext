using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class orderLst_20080922
{
    public int order_seq { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? order_type { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isChoanRisk { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isSpecial { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? sales_Gubun { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? site_gubun { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? pay_Type { get; set; }

    public int? company_seq { get; set; }

    [StringLength(128)]
    [Unicode(false)]
    public string COMPANY_NAME { get; set; } = null!;

    public int? up_order_seq { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? order_add_flag { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? order_add_type { get; set; }

    public int status_seq { get; set; }

    [StringLength(16)]
    [Unicode(false)]
    public string? member_id { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? order_hphone { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? order_email { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? src_compose_admin_id { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? src_compose_mod_admin_id { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? order_date { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? src_compose_date { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? src_confirm_date { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? src_modRequest_date { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? src_compose_mod_date { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? src_printW_date { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? src_print_date { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? src_printCopy_date { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? src_CloseCopy_date { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? src_jebon_date { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? src_packing_date { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? src_send_date { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? order_name { get; set; }

    public byte? settle_status { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isinpaper { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ishandmade { get; set; }

    public int? fticket_price { get; set; }

    public int? embo_price { get; set; }

    public int? envInsert_price { get; set; }

    public int? mini_price { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isCompose { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Expr1 { get; set; }

    public byte? ProcLevel { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? couponseq { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string CARD_CODE { get; set; } = null!;

    public int? order_count { get; set; }

    public int? order_price { get; set; }

    public int settle_price { get; set; }

    public int? last_total_price { get; set; }

    [StringLength(265)]
    [Unicode(false)]
    public string? etc_name { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? wedd_name { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? Expr2 { get; set; }

    public short? COMPANY { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? map_trans_method { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isCorel { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isBaesongRisk { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isRibon { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isColorPrint { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? trouble_type { get; set; }
}
