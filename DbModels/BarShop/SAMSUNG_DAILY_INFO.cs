using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 삼성전자동의 전송 데이터
/// </summary>
[Index("reg_date_s", "ConnInfo", Name = "IX_SAMSUNG_DAILY_INFO_regdate_s")]
public partial class SAMSUNG_DAILY_INFO
{
    [Key]
    public int seq { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? ConnInfo { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? uid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? uname { get; set; }

    [StringLength(8)]
    [Unicode(false)]
    public string? Birthdate { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Gender { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? p_gubun { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? phone1 { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? phone2 { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? phone3 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? hand_phone1 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? hand_phone2 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? hand_phone3 { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? chk_TM { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? zip1 { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? zip2 { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? address { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? addr_detail { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? c_zip1 { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? c_zip2 { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? c_address { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? c_addr_detail { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? chk_DM { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? chk_sms { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? reg_date { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? umail { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? chk_mailservice { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? chk_aoi { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? chk_tpa { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? secession { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? site_div { get; set; }

    [StringLength(5)]
    [Unicode(false)]
    public string? ugubun { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string? wedd_year { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? wedd_month { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? wedd_day { get; set; }

    /// <summary>
    /// 웨딩장소
    /// </summary>
    [StringLength(2)]
    [Unicode(false)]
    public string? wedd_pgubun { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? reg_date_s { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? smembership_reg_date { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? smembership_leave_date { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? mod_date { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? chk_smembership { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? smembership_period { get; set; }
}
