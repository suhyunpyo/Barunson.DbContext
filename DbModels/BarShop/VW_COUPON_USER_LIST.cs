using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class VW_COUPON_USER_LIST
{
    public int COUPON_MST_SEQ { get; set; }

    public int COUPON_DETAIL_SEQ { get; set; }

    public int COUPON_ISSUE_SEQ { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string COUPON_CODE { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string UID { get; set; } = null!;

    public int COMPANY_SEQ { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string SALES_GUBUN { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string ACTIVE_YN { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? END_DATE { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? REG_DATE { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string EXPIRY_TYPE { get; set; } = null!;

    public int EXPIRY_CUSTOM_VALUE { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EXPIRY_START_DATE { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? EXPIRY_END_DATE { get; set; }

    [StringLength(50)]
    public string COUPON_NAME { get; set; } = null!;

    [StringLength(1000)]
    public string COUPON_DESC { get; set; } = null!;

    [StringLength(6)]
    [Unicode(false)]
    public string COUPON_GROUP_CODE { get; set; } = null!;

    [StringLength(6)]
    [Unicode(false)]
    public string COUPON_TYPE_CODE { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string ORDER_TYPE_CODE { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string DUP_COUPON_ALLOW_YN { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string AD_COUPON_ALLOW_YN { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string ADD_COUPON_ALLOW_YN { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string ORDER_APPLY_TYPE { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string DOWNLOAD_KIND { get; set; } = null!;

    [StringLength(6)]
    [Unicode(false)]
    public string? DOWNLOAD_KIND_ETC_CODE { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string DOWNLOAD_USER_GB { get; set; } = null!;

    [StringLength(5)]
    public string USE_PLACE { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string USE_DEVICE { get; set; } = null!;

    public int DISCOUNT_VALUE { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string DISCOUNT_FIXED_RATE_TYPE { get; set; } = null!;

    public int DISCOUNT_MAX_AMT { get; set; }

    public int ORDER_AMT { get; set; }

    public int ORDER_CNT { get; set; }

    public int CARD_ORDER_CNT { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string STATUS_ACTIVE_YN { get; set; } = null!;
}
