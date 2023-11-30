using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class CUSTOM_SAMPLE_ORDER_deardup
{
    public int sample_order_seq { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string SALES_GUBUN { get; set; } = null!;

    public int COMPANY_SEQ { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? MEMBER_ID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string MEMBER_NAME { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? MEMBER_EMAIL { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? MEMBER_FAX { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? MEMBER_PHONE { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string MEMBER_ZIP { get; set; } = null!;

    [StringLength(255)]
    [Unicode(false)]
    public string MEMBER_ADDRESS { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? MEMBER_ADDRESS_DETAIL { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime REQUEST_DATE { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? PREPARE_DATE { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? DELIVERY_DATE { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? DELIVERY_CODE_NUM { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string DELIVERY_METHOD { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string? DELIVERY_COM { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? MEMO { get; set; }

    public byte? DELIVERY_CHANGO { get; set; }

    public int STATUS_SEQ { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? INVOICE_PRINT_YORN { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? JOB_ORDER_PRINT_YORN { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? DSP_PRINT_YORN { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? SETTLE_MOBILID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? SETTLE_DATE { get; set; }

    [StringLength(13)]
    [Unicode(false)]
    public string? SETTLE_HPHONE { get; set; }

    public short? CARD_PRICE { get; set; }

    public short? REDUCE_PRICE { get; set; }

    public short? DELIVERY_PRICE { get; set; }

    public int? SETTLE_PRICE { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? SETTLE_CANCEL { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? BUY_CONF { get; set; }

    [StringLength(25)]
    [Unicode(false)]
    public string? ADMIN_ID { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? SETTLE_METHOD { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? MEMBER_HPHONE { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ISDACOM { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? PG_MERTID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? PG_TID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? DACOM_TID { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string? PG_RESULTINFO { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? PG_RESULTINFO2 { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? card_installmonth { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? card_nointyn { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? CANCEL_DATE { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? CANCEL_REASON { get; set; }

    public double? PG_FEE { get; set; }

    public double? PG_REFEE { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PG_PAYDATE { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PG_CALDATE { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PG_REPAYDATE { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? PG_RECALDATE { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? SRC_ERP_DATE { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isAscrow { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isHJ { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isVar { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? call_admin_id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? etc_info_s { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? join_division { get; set; }

    public int? order_g_seq { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isOneClickSample { get; set; }

    public int? MULTI_PACK_SEQ { get; set; }

    public int? MULTI_PACK_SUB_SEQ { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? MULTI_PACK_REG_DATE { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? WEDD_DATE { get; set; }

    [StringLength(10)]
    public string? OPT_GUBUN { get; set; }

    [StringLength(4)]
    public string? OPT_VALUES { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? WisaFlag { get; set; }
}
