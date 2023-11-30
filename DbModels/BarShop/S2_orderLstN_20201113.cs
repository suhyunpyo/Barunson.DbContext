using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class S2_orderLstN_20201113
{
    public int order_seq { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? order_type { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isChoanRisk { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isSpecial { get; set; }

    [StringLength(2)]
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

    [StringLength(20)]
    [Unicode(false)]
    public string erp_partcode { get; set; } = null!;

    public int? up_order_seq { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? order_add_flag { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? order_add_type { get; set; }

    public int status_seq { get; set; }

    [StringLength(50)]
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
    public DateTime? settle_date { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? src_ap_date { get; set; }

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

    public short? src_printer_seq { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? src_packing_date { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? src_send_date { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? order_name { get; set; }

    public byte? settle_status { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isinpaper { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ishandmade { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isEnvInsert { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isLiningJaebon { get; set; }

    public int fticket_price { get; set; }

    public int embo_price { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isEmbo { get; set; }

    public int envInsert_price { get; set; }

    public int mini_price { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isColorInpaper { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isCompose { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Expr1 { get; set; }

    public byte? ProcLevel { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? couponseq { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? card_code { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string old_code { get; set; } = null!;

    [StringLength(152)]
    [Unicode(false)]
    public string? card_code_str { get; set; }

    public int? Master_2Color { get; set; }

    public int? order_count { get; set; }

    public int order_price { get; set; }

    public int settle_price { get; set; }

    public int unicef_price { get; set; }

    public int last_total_price { get; set; }

    [StringLength(605)]
    public string? etc_name { get; set; }

    [StringLength(200)]
    public string? wedd_name { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string wedd_phone { get; set; } = null!;

    [Column(TypeName = "smalldatetime")]
    public DateTime? Expr2 { get; set; }

    [StringLength(12)]
    [Unicode(false)]
    public string? brand_code { get; set; }

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

    [StringLength(4)]
    [Unicode(false)]
    public string? trouble_type { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isVar { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? settle_method { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? discount_in_advance_cancel_date { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? discount_in_advance_reg_date { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? discount_in_advance { get; set; }

    public int? cancel_user_type { get; set; }

    [StringLength(200)]
    public string? cancel_type_comment { get; set; }

    public int? cancel_type { get; set; }

    [StringLength(200)]
    public string? wedd_place { get; set; }

    [StringLength(1000)]
    public string? wedd_addr { get; set; }

    public int? order_g_seq { get; set; }

    public int isLaser { get; set; }

    public int laser_price { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string Inflow_Route_Order { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string Inflow_Route_Settle { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? addition_couponseq { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string PrintMethod { get; set; } = null!;

    public int isMasterDigital { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? Auto_Choan_Status_Code { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? Auto_Choan_Status_Name { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string isEnvCharge { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string isEnvSpecial { get; set; } = null!;

    public int? sasik_price { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string crnc_flag { get; set; } = null!;
}
