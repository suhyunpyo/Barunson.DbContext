using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Index("P_SSN_CI", Name = "NCI_S2_Userinfo_Hiplazza_Log_SSN_CI")]
[Index("uid", Name = "NCI_S2_Userinfo_Hiplazza_Log_uid")]
[Index("result_date", Name = "NCI_S2_Userinfo_Hiplazza_result_date")]
public partial class S2_Userinfo_HiPlaza_Log
{
    [Key]
    [Column(TypeName = "numeric(18, 0)")]
    public decimal id { get; set; }

    [StringLength(50)]
    public string uid { get; set; } = null!;

    /// <summary>
    /// 유입경로(디얼디어:DEAR, 바른손:BSON)
    /// </summary>
    [StringLength(10)]
    public string? P_RQST_FLAG { get; set; }

    [StringLength(20)]
    public string? P_ORG_CD { get; set; }

    [StringLength(100)]
    public string P_CUST_NM { get; set; } = null!;

    [StringLength(100)]
    public string P_SSN_CI { get; set; } = null!;

    [StringLength(4)]
    public string P_MOBILE_DDD { get; set; } = null!;

    [StringLength(4)]
    public string P_MOBILE_NO1 { get; set; } = null!;

    [StringLength(4)]
    public string P_MOBILE_NO2 { get; set; } = null!;

    [StringLength(4)]
    public string P_TEL_DDD { get; set; } = null!;

    [StringLength(4)]
    public string P_TEL_NO1 { get; set; } = null!;

    [StringLength(4)]
    public string P_TEL_NO2 { get; set; } = null!;

    [StringLength(50)]
    public string P_PI_MOTION_YN { get; set; } = null!;

    [StringLength(50)]
    public string P_SMS_RCV_YN { get; set; } = null!;

    [StringLength(50)]
    public string P_DM_RCV_YN { get; set; } = null!;

    [StringLength(50)]
    public string P_TM_RCV_YN { get; set; } = null!;

    [StringLength(50)]
    public string P_EMAIL_RCV_YN { get; set; } = null!;

    [StringLength(100)]
    public string? P_EMAIL_ID { get; set; }

    [StringLength(50)]
    public string P_SEX { get; set; } = null!;

    [StringLength(8)]
    public string P_BIRTHDAY_DATE { get; set; } = null!;

    [StringLength(50)]
    public string? P_SOLAR_CALENDAR_YN { get; set; }

    [StringLength(6)]
    public string P_POST_CD { get; set; } = null!;

    [StringLength(100)]
    public string P_ADDR1 { get; set; } = null!;

    [StringLength(100)]
    public string P_ADDR2 { get; set; } = null!;

    [StringLength(8)]
    public string P_WEDDING_DATE { get; set; } = null!;

    [StringLength(4)]
    public string? RTN_CD { get; set; }

    [StringLength(300)]
    public string? RTN_MSG { get; set; }

    [StringLength(50)]
    public string? MLG_CUST_ID { get; set; }

    [StringLength(16)]
    public string? MBS_CARD_NO { get; set; }

    [StringLength(2000)]
    public string? JSON_STR { get; set; }

    [StringLength(3000)]
    public string? ENCODE_STR { get; set; }

    [StringLength(400)]
    public string? DECODE_STR { get; set; }

    [StringLength(400)]
    public string? RESULT_JSON_STR { get; set; }

    /// <summary>
    /// LG 하이플라자 가입 정보 발송 로그
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime reg_date { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? result_date { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? cancel_date { get; set; }

    [StringLength(2)]
    public string? site_div { get; set; }
}
