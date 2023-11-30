using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class VW_COUPON_CALC_FOR_CO_20200303_bak
{
    public int ORDER_SEQ { get; set; }

    public int? UP_ORDER_SEQ { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? UID { get; set; }

    public int? COMPANY_SEQ { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? SALES_GUBUN { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? ORDER_TYPE { get; set; }

    public int? COUPON_ISSUE_SEQ { get; set; }

    public int COUPON_DETAIL_SEQ { get; set; }

    [StringLength(50)]
    public string? COUPON_NAME { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? COUPON_TYPE_CODE { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? COUPON_SERVICE_TYPE_CODE { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? COUPON_SERVICE_TYPE_NAME { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? DUP_COUPON_ALLOW_YN { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? AD_COUPON_ALLOW_YN { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ADD_COUPON_ALLOW_YN { get; set; }

    public int? CARD_SEQ { get; set; }

    public int? ORDER_COUNT { get; set; }

    public int? LAST_TOTAL_PRICE { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? USE_DEVICE { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? DISCOUNT_FIXED_RATE_TYPE { get; set; }

    public int? DISCOUNT_VALUE { get; set; }

    public int? DISCOUNT_MAX_AMT { get; set; }

    public int ORDER_PRICE { get; set; }

    public int FTICKET_PRICE { get; set; }

    public int GUESTBOOK_PRICE { get; set; }

    public int LINING_ENV_PRICE { get; set; }

    public int PRINT_PRICE { get; set; }

    public int EMBO_PRICE { get; set; }

    public int JEBON_PRICE { get; set; }

    public int ENVINSERT_PRICE { get; set; }

    public int EXPRESS_SHIPPING_PRICE { get; set; }

    public int DELIVERY_PRICE { get; set; }

    public int DISCOUNT_TARGET_ORDER_PRICE { get; set; }

    public int DISCOUNT_TARGET_FTICKET_PRICE { get; set; }

    public int DISCOUNT_TARGET_GUESTBOOK_PRICE { get; set; }

    public int DISCOUNT_TARGET_LINING_ENV_PRICE { get; set; }

    public int DISCOUNT_TARGET_PRINT_PRICE { get; set; }

    public int DISCOUNT_TARGET_EMBO_PRICE { get; set; }

    public int DISCOUNT_TARGET_JEBON_PRICE { get; set; }

    public int DISCOUNT_TARGET_ENVINSERT_PRICE { get; set; }

    public int DISCOUNT_TARGET_DELIVERY_PRICE { get; set; }

    public int DISCOUNT_TARGET_EXPRESS_SHIPPING_PRICE { get; set; }

    [Column(TypeName = "numeric(29, 6)")]
    public decimal DISCOUNT_ORDER_PRICE { get; set; }

    [Column(TypeName = "numeric(29, 6)")]
    public decimal DISCOUNT_FTICKET_PRICE { get; set; }

    [Column(TypeName = "numeric(29, 6)")]
    public decimal DISCOUNT_GUESTBOOK_PRICE { get; set; }

    [Column(TypeName = "numeric(29, 6)")]
    public decimal DISCOUNT_LINING_ENV_PRICE { get; set; }

    [Column(TypeName = "numeric(29, 6)")]
    public decimal DISCOUNT_PRINT_PRICE { get; set; }

    [Column(TypeName = "numeric(29, 6)")]
    public decimal DISCOUNT_EMBO_PRICE { get; set; }

    [Column(TypeName = "numeric(29, 6)")]
    public decimal DISCOUNT_JEBON_PRICE { get; set; }

    [Column(TypeName = "numeric(29, 6)")]
    public decimal DISCOUNT_ENVINSERT_PRICE { get; set; }

    [Column(TypeName = "numeric(29, 6)")]
    public decimal DISCOUNT_DELIVERY_PRICE { get; set; }

    [Column(TypeName = "numeric(29, 6)")]
    public decimal DISCOUNT_EXPRESS_SHIPPING_PRICE { get; set; }

    [Column(TypeName = "numeric(29, 6)")]
    public decimal DISCOUNT_TOTAL_PRICE { get; set; }
}
