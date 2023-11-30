using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
[Index("order_seq", Name = "IX_custom_order_backup_order_seq")]
public partial class custom_order_backup
{
    public int order_seq { get; set; }

    public int? up_order_seq { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? order_type { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? sales_Gubun { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? site_gubun { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? pay_Type { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? print_type { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? trouble_type { get; set; }

    public int? company_seq { get; set; }

    public int status_seq { get; set; }

    public byte? settle_status { get; set; }

    public byte? printW_status { get; set; }

    public byte? mini_status_seq { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isStoreRequisit { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? coop_orderid { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? order_date { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? src_ap_date { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? src_compose_date { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? src_modRequest_date { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? src_compose_mod_date { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? src_confirm_date { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? src_printCopy_date { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? src_CloseCopy_date { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? src_printW_date { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? src_print_date { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? src_print_commit_date { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? src_jebon_date { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? src_jebon_commit_date { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? src_packing_date { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? src_sendW_date { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? src_send_date { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? src_cancel_date { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? src_mini_print_date { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? src_mini_cut_date { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? src_mini_packing_date { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? src_erp_date { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? src_ap_admin_id { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? src_compose_admin_id { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? src_compose_mod_admin_id { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? src_PrintCopy_admin_id { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? src_print_admin_id { get; set; }

    public short? src_printer_seq { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? src_cancel_admin_id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? member_id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? order_name { get; set; }

    [StringLength(50)]
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
    public string? order_faxphone { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? order_etc_comment { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? order_gname { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? order_bname { get; set; }

    public int? card_seq { get; set; }

    public int? order_count { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? card_opt { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? order_add_flag { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? order_add_type { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isLiningJaebon { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isinpaper { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ishandmade { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isRibon { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isEmbo { get; set; }

    public byte? ProcLevel { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isCompose { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isPrintCopy { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isPDF { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isChoanRisk { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isBaesongRisk { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isContAdd { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isEnvAdd { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isEnvInsert { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isFTicket { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isColorInpaper { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isColorPrint { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isReceipt { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isCorel { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isSpecial { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? couponseq { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? etc_price_ment { get; set; }

    public int? order_price { get; set; }

    public double? discount_rate { get; set; }

    public int? order_total_price { get; set; }

    public int? delivery_price { get; set; }

    public int? jebon_price { get; set; }

    public int? sticker_price { get; set; }

    public int? mini_price { get; set; }

    public int? embo_price { get; set; }

    public int? etc_price { get; set; }

    public int? env_price { get; set; }

    public int? guestbook_price { get; set; }

    public int? cont_price { get; set; }

    public int? option_price { get; set; }

    public int? reduce_price { get; set; }

    public int? fticket_price { get; set; }

    public int? print_price { get; set; }

    public int? sasik_price { get; set; }

    public int? label_price { get; set; }

    public int? envInsert_price { get; set; }

    public int? coop_sale_price { get; set; }

    public int? last_total_price { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? settle_date { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? settle_cancel_date { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? settle_method { get; set; }

    public int? settle_price { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? pg_shopid { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? pg_tid { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? dacom_tid { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? card_installmonth { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? card_nointyn { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? pg_receipt_tid { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? pg_resultinfo { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? pg_resultinfo2 { get; set; }

    public byte? pg_status { get; set; }

    public int? pg_payprice { get; set; }

    public double? pg_fee { get; set; }

    public int? weddinfo_id { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? pg_paydate { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? pg_repaydate { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? pg_caldate { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? pg_recaldate { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? PosFlag { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PB_Coupon { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isColorPrt_card { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isColorPrt_env { get; set; }

    public int? unicef_price { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isAscrow { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? print_color { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isVar { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isWMovie { get; set; }

    public int? point_price { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isEnvSpecial { get; set; }

    public int? LiningJaebon_price { get; set; }

    public int? tmap_price { get; set; }

    public int? cancel_type { get; set; }

    [StringLength(200)]
    public string? cancel_type_comment { get; set; }

    public int? cancel_user_type { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? discount_in_advance { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? discount_in_advance_reg_date { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? discount_in_advance_cancel_date { get; set; }

    public int? EventIdx { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? inflow_route { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? OUTSOURCING_TYPE { get; set; }

    public int? order_g_seq { get; set; }

    public int? moneyenv_price { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isEnvCharge { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isMoneyEnv { get; set; }

    [StringLength(3)]
    public string? isLanguage { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? OUTSOURCING_RECEIPT_DATE { get; set; }

    public int? laser_price { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? OUTSOURCING_MERGE_TYPE_CODE { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? OUTSOURCING_PRINTING_HOUSE_TYPE_CODE { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? inflow_route_settle { get; set; }

    public int? addition_reduce_price { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? addition_couponseq { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? AUTO_CHOAN_STATUS_CODE { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? AUTO_CHOAN_REG_DATE { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? AUTO_CHOAN_UPLOAD_CODE { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? AUTO_CHOAN_UPLOAD_REG_DATE { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? Trouble_Comment { get; set; }

    public int? MemoryBook_Price { get; set; }

    public int? EnvSpecial_Price { get; set; }

    public int? unit_price { get; set; }

    public int? flower_price { get; set; }

    public int? sealing_sticker_price { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isPerfume { get; set; }

    public int? perfume_price { get; set; }

    public int? AddPrice { get; set; }

    public int? ribbon_price { get; set; }

    public int? paperCover_price { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? WisaFlag { get; set; }

    public int? Mask_Price { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isMiniCard { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isCCG { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string ishandmade2 { get; set; } = null!;

    public int jebon2_price { get; set; }

    public int Pocket_price { get; set; }

    public int? EnvPremium_price { get; set; }

    public int? MaskingTape_price { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? trouble_version { get; set; }

    [StringLength(12)]
    [Unicode(false)]
    public string? trouble_type_new { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? trouble_worker { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PACKING_EXPECTED_DATE { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? PACKING_EXPECTED_CHECK { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? IsThanksCard { get; set; }
}
