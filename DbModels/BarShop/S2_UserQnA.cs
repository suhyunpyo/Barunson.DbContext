using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 고객문의
/// </summary>
[Keyless]
public partial class S2_UserQnA
{
    public int qa_iid { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string sales_gubun { get; set; } = null!;

    public int company_seq { get; set; }

    /// <summary>
    /// 제품코드
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string? card_code { get; set; }

    /// <summary>
    /// 주문번호
    /// </summary>
    public int? order_seq { get; set; }

    /// <summary>
    /// 회원ID
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string? member_id { get; set; }

    /// <summary>
    /// 이름
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string member_name { get; set; } = null!;

    /// <summary>
    /// 이메일
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string e_mail { get; set; } = null!;

    /// <summary>
    /// 연락처
    /// </summary>
    [StringLength(20)]
    [Unicode(false)]
    public string? tel_no { get; set; }

    /// <summary>
    /// 이메일 입력 방법 (Y:직접입력, N:선택입력)
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string? chk_mail_input { get; set; }

    /// <summary>
    /// 질문 구분 (K2:결제부분, K4:배송관련, K5:상품문의, K7:추가주문문의, K8:서비스문의, K9:이벤트문의, K10:시스템문의, K11:개인정보문의)
    /// </summary>
    [StringLength(20)]
    [Unicode(false)]
    public string? q_kind { get; set; }

    /// <summary>
    /// 질문 제목
    /// </summary>
    [StringLength(100)]
    [Unicode(false)]
    public string q_title { get; set; } = null!;

    /// <summary>
    /// 질문 내용
    /// </summary>
    [Column(TypeName = "text")]
    public string q_content { get; set; } = null!;

    /// <summary>
    /// 메일 수신 여부 (0:no, 1:yes)
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string? isMail { get; set; }

    /// <summary>
    /// sms 문자 수신 여부 (0:no, 1:yes)
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string? isSMS { get; set; }

    /// <summary>
    /// 비공개 (0:no, 1:yes)
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string? isSecret { get; set; }

    /// <summary>
    /// 첨부파일1
    /// </summary>
    [StringLength(100)]
    [Unicode(false)]
    public string? user_upfile1 { get; set; }

    /// <summary>
    /// 첨부파일2
    /// </summary>
    [StringLength(100)]
    [Unicode(false)]
    public string? user_upfile2 { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? admin_upfile1 { get; set; }

    /// <summary>
    /// 답변한 상담원 아이디
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string? a_id { get; set; }

    /// <summary>
    /// 답변한 날짜
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime? a_dt { get; set; }

    /// <summary>
    /// 답변한 내용
    /// </summary>
    [Column(TypeName = "text")]
    public string? a_content { get; set; }

    /// <summary>
    /// 답변 구분(S1:등록, S2:처리중, S3:답변등록, S4:삭제)
    /// </summary>
    [StringLength(2)]
    [Unicode(false)]
    public string a_stat { get; set; } = null!;

    /// <summary>
    /// 작성일
    /// </summary>
    [Column(TypeName = "datetime")]
    public DateTime reg_dt { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? a_research1 { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? a_research2 { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? a_research_date { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? inflow { get; set; }
}
