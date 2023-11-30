using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// SmartAD 지문방명록 이벤트
/// </summary>
public partial class SMARTAD_EVENT_INFO
{
    [Key]
    public int EVENT_SEQ { get; set; }

    public int? AD_SEQ { get; set; }

    [StringLength(20)]
    public string? EVENT_TYPE { get; set; }

    [StringLength(50)]
    public string? FRAME_TYPE { get; set; }

    [StringLength(50)]
    public string? USER_NAME { get; set; }

    [StringLength(100)]
    public string? USER_PHONE { get; set; }

    [StringLength(100)]
    public string? USER_HPHONE { get; set; }

    [StringLength(100)]
    public string? USER_EMAIL { get; set; }

    [StringLength(50)]
    public string? USER_PWD { get; set; }

    [StringLength(30)]
    public string? COUPON_CODE { get; set; }

    [StringLength(1000)]
    public string? PARAM1 { get; set; }

    [StringLength(1000)]
    public string? PARAM2 { get; set; }

    [StringLength(1000)]
    public string? PARAM3 { get; set; }

    [StringLength(1000)]
    public string? PARAM4 { get; set; }

    [StringLength(1000)]
    public string? PARAM5 { get; set; }

    [StringLength(1000)]
    public string? PARAM6 { get; set; }

    [StringLength(1000)]
    public string? PARAM7 { get; set; }

    [StringLength(2000)]
    public string? MEMO { get; set; }

    [StringLength(2000)]
    public string? IMG_URL { get; set; }

    [StringLength(2000)]
    public string? IMG_URL2 { get; set; }

    [StringLength(2000)]
    public string? IMG_URL3 { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? STATUS_CODE { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? WEDD_DATE { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CHOAN_DATE { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? MODIFY_DATE { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CONFIRM_DATE { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? PRINT_DATE { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DELIVERY_DATE { get; set; }

    [StringLength(50)]
    public string? DELIVERY_CD { get; set; }

    [StringLength(50)]
    public string? DELIVERY_NUM { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? REG_DATE { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UPD_DATE { get; set; }

    [StringLength(50)]
    public string? UPD_ID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? CANCEL_DATE { get; set; }

    [StringLength(50)]
    public string? CANCEL_ID { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? DEL_YN { get; set; }
}
