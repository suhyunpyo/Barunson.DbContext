using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 모바일초대장-Toss축의금사용정보
/// </summary>
public partial class Mcard_MoneyGift
{
    [Key]
    public int InvitationID { get; set; }

    /// <summary>
    /// 초대장주문번호
    /// </summary>
    [StringLength(10)]
    [Unicode(false)]
    public string InvitationCode { get; set; } = null!;

    /// <summary>
    /// 신랑은행코드
    /// </summary>
    [StringLength(5)]
    [Unicode(false)]
    public string Groom_BankCode { get; set; } = null!;

    /// <summary>
    /// 신랑계좌번호
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string Groom_Account { get; set; } = null!;

    /// <summary>
    /// 송금서비스이용 등록 API 응답-신랑송금페이지링크
    /// </summary>
    [Unicode(false)]
    public string? Groom_URL { get; set; }

    /// <summary>
    /// 신부은행코드
    /// </summary>
    [StringLength(5)]
    [Unicode(false)]
    public string Birde_BankCode { get; set; } = null!;

    /// <summary>
    /// 신부계좌번호
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string Birde_Account { get; set; } = null!;

    /// <summary>
    /// 송금서비스이용 등록 API 응답-신부송금페이지링크
    /// </summary>
    [Unicode(false)]
    public string? Birde_URL { get; set; }

    /// <summary>
    /// 예식일
    /// </summary>
    [StringLength(10)]
    [Unicode(false)]
    public string? Wedding_Date { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? Created_Tmstmp { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? UPDATED_Tmstmp { get; set; }

    /// <summary>
    /// 계좌유효성체크 신랑 응답코드
    /// </summary>
    [StringLength(100)]
    [Unicode(false)]
    public string? Return_Groom_AccountCode { get; set; }

    /// <summary>
    /// 계좌유효성체크 신랑응답메시지
    /// </summary>
    [StringLength(1000)]
    [Unicode(false)]
    public string? Return_Groom_AccountMessage { get; set; }

    /// <summary>
    /// 계좌유효성체크 신부 응답코드
    /// </summary>
    [StringLength(100)]
    [Unicode(false)]
    public string? Return_Birde_AccountCode { get; set; }

    /// <summary>
    /// 계좌유효성체크 신부 응답메시지
    /// </summary>
    [StringLength(1000)]
    [Unicode(false)]
    public string? Return_Birde_AccountMessage { get; set; }

    /// <summary>
    /// 신랑예금주명
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string Return_AccountGroomName { get; set; } = null!;

    /// <summary>
    /// 신부예금주명
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string Return_AccountBirdeName { get; set; } = null!;

    /// <summary>
    /// 송금 서비스 이용 등록 API 응답코드
    /// </summary>
    [StringLength(5)]
    [Unicode(false)]
    public string? Return_Code { get; set; }

    /// <summary>
    /// 송금 서비스 이용 등록 API 응답메시지
    /// </summary>
    [Unicode(false)]
    public string? Return_Message { get; set; }

    /// <summary>
    /// 추후 등록된 계좌 정보를 disable 처리할 경우에 필요한 값
    /// </summary>
    [StringLength(100)]
    [Unicode(false)]
    public string? Return_CoupleKey { get; set; }

    /// <summary>
    /// 응답코드받은시간
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? Return_Updated_Tmstmp { get; set; }

    /// <summary>
    /// 신랑신부 계좌번호변경시 사용함
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string DisableYN { get; set; } = null!;

    /// <summary>
    /// 계좌 정보 disable 처리 응답코드
    /// </summary>
    [StringLength(5)]
    [Unicode(false)]
    public string? Return_Disable_Code { get; set; }

    [Unicode(false)]
    public string? Return_Disable_Message { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? DisableY_Tmstmp { get; set; }
}
