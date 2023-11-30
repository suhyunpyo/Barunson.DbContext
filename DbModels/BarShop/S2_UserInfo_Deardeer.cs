using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 사용자관리
/// </summary>
public partial class S2_UserInfo_Deardeer
{
    /// <summary>
    /// 아이디
    /// </summary>
    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string uid { get; set; } = null!;

    /// <summary>
    /// 이름
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string uname { get; set; } = null!;

    /// <summary>
    /// 이메일
    /// </summary>
    [StringLength(100)]
    [Unicode(false)]
    public string umail { get; set; } = null!;

    /// <summary>
    /// 생일
    /// </summary>
    [StringLength(10)]
    [Unicode(false)]
    public string? birth { get; set; }

    /// <summary>
    /// 생일구분
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string? birth_div { get; set; }

    /// <summary>
    /// 우편번호1
    /// </summary>
    [StringLength(3)]
    [Unicode(false)]
    public string? zip1 { get; set; }

    /// <summary>
    /// 우편번호2
    /// </summary>
    [StringLength(3)]
    [Unicode(false)]
    public string? zip2 { get; set; }

    /// <summary>
    /// 주소1
    /// </summary>
    [StringLength(150)]
    [Unicode(false)]
    public string? address { get; set; }

    /// <summary>
    /// 주소2
    /// </summary>
    [StringLength(100)]
    [Unicode(false)]
    public string? addr_detail { get; set; }

    /// <summary>
    /// 휴대전화
    /// </summary>
    [StringLength(4)]
    [Unicode(false)]
    public string phone1 { get; set; } = null!;

    /// <summary>
    /// 전화번호2
    /// </summary>
    [StringLength(4)]
    [Unicode(false)]
    public string? phone2 { get; set; }

    /// <summary>
    /// 전화번호3
    /// </summary>
    [StringLength(4)]
    [Unicode(false)]
    public string? phone3 { get; set; }

    /// <summary>
    /// 휴대전화1
    /// </summary>
    [StringLength(4)]
    [Unicode(false)]
    public string? hand_phone1 { get; set; }

    /// <summary>
    /// 휴대전화2
    /// </summary>
    [StringLength(4)]
    [Unicode(false)]
    public string? hand_phone2 { get; set; }

    /// <summary>
    /// 휴대전화3
    /// </summary>
    [StringLength(4)]
    [Unicode(false)]
    public string? hand_phone3 { get; set; }

    /// <summary>
    /// 이메일 수신동의여부
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string chk_mailservice { get; set; } = null!;

    /// <summary>
    /// SMS 수신동의여부
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string chk_sms { get; set; } = null!;

    /// <summary>
    /// 가입채널
    /// </summary>
    [StringLength(2)]
    [Unicode(false)]
    public string? site_div { get; set; }

    /// <summary>
    /// 중복가입확인번호
    /// </summary>
    [StringLength(100)]
    [Unicode(false)]
    public string? dupinfo { get; set; }

    /// <summary>
    /// 고유번호
    /// </summary>
    [StringLength(100)]
    [Unicode(false)]
    public string? conninfo { get; set; }

    /// <summary>
    /// 성별 - F: 여자, M: 남자
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string? gender { get; set; }

    /// <summary>
    /// 회원가입 예상 예식일자
    /// </summary>
    [StringLength(4)]
    [Unicode(false)]
    public string wedd_year { get; set; } = null!;

    /// <summary>
    /// 예식월
    /// </summary>
    [StringLength(2)]
    [Unicode(false)]
    public string? wedd_month { get; set; }

    /// <summary>
    /// 예식일
    /// </summary>
    [StringLength(2)]
    [Unicode(false)]
    public string? wedd_day { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? wedd_pggubun { get; set; }

    /// <summary>
    /// 등록일
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? reg_date { get; set; }

    /// <summary>
    /// 수정일
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? mod_date { get; set; }
}
