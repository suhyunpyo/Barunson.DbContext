using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 커스텀 제작/견적 문의
/// </summary>
public partial class ESTIMATE_REQUEST
{
    /// <summary>
    /// 일련번호
    /// </summary>
    [Key]
    public int seq { get; set; }

    /// <summary>
    /// 사이트구분 코드
    /// </summary>
    [StringLength(2)]
    public string sales_gubun { get; set; } = null!;

    /// <summary>
    /// 사이트구분 번호
    /// </summary>
    public int company_seq { get; set; }

    /// <summary>
    /// 회사명
    /// </summary>
    [StringLength(50)]
    public string company_name { get; set; } = null!;

    /// <summary>
    /// 회사위치
    /// </summary>
    [StringLength(50)]
    public string? company_location { get; set; }

    /// <summary>
    /// 성함
    /// </summary>
    [StringLength(50)]
    public string person_name { get; set; } = null!;

    /// <summary>
    /// 이메일
    /// </summary>
    [StringLength(100)]
    public string person_email { get; set; } = null!;

    /// <summary>
    /// 연락처1
    /// </summary>
    [StringLength(3)]
    public string person_phone1 { get; set; } = null!;

    /// <summary>
    /// 연락처2
    /// </summary>
    [StringLength(4)]
    public string person_phone2 { get; set; } = null!;

    /// <summary>
    /// 연락처3
    /// </summary>
    [StringLength(4)]
    public string person_phone3 { get; set; } = null!;

    /// <summary>
    /// 제작정보 타입
    /// </summary>
    [StringLength(1)]
    public string? product_type { get; set; }

    /// <summary>
    /// 제작정보 문의사항
    /// </summary>
    [Column(TypeName = "text")]
    public string? product_content { get; set; }

    /// <summary>
    /// 제작정보 요청수량
    /// </summary>
    [StringLength(50)]
    public string? product_count { get; set; }

    /// <summary>
    /// 제작정보 납기예상일
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? product_duedate { get; set; }

    /// <summary>
    /// 기타정보 파일첨부
    /// </summary>
    [StringLength(50)]
    public string? etc_upfile { get; set; }

    /// <summary>
    /// 기타정보 추가문의
    /// </summary>
    [Column(TypeName = "text")]
    public string? etc_content { get; set; }

    /// <summary>
    /// 관리자확인 여부
    /// </summary>
    [StringLength(1)]
    public string? chk_admin { get; set; }

    /// <summary>
    /// 관리자확인 일자
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? chk_date { get; set; }

    /// <summary>
    /// 관리자 메모
    /// </summary>
    [Column(TypeName = "text")]
    public string? admin_content { get; set; }

    /// <summary>
    /// 삭제여부
    /// </summary>
    [StringLength(1)]
    public string? delete_ind { get; set; }

    /// <summary>
    /// 생성일
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? CREATED_TMSTMP { get; set; }

    /// <summary>
    /// 생성자
    /// </summary>
    [StringLength(50)]
    public string? CREATED_USERID { get; set; }

    public string? MailContents { get; set; }

    public bool? SendMailYn { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? SendMailDate { get; set; }
}
