using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 빠른손 관리자 목록
/// </summary>
public partial class ADMIN_LST
{
    public int id { get; set; }

    /// <summary>
    /// 관리자ID
    /// </summary>
    [Key]
    [StringLength(25)]
    [Unicode(false)]
    public string ADMIN_ID { get; set; } = null!;

    [StringLength(25)]
    [Unicode(false)]
    public string? ADMIN_PASSWD { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ADMIN_NAME { get; set; }

    /// <summary>
    /// 콜센터 어드민 아이디
    /// </summary>
    [StringLength(20)]
    [Unicode(false)]
    public string? CMS_ID { get; set; }

    /// <summary>
    /// 콜센터 접속 전화번호
    /// </summary>
    [StringLength(10)]
    [Unicode(false)]
    public string? CMS_NUM { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ADMIN_PHONE { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? ADMIN_EMAIL { get; set; }

    /// <summary>
    /// 1:온라인,2:매장/영업
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string COMPANY_TYPE { get; set; } = null!;

    public int COMPANY_SEQ { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? COMPANY_GUBUN { get; set; }

    /// <summary>
    /// 1일때 전체권한,0일때 e청첩장 관리
    /// </summary>
    public byte? ADMIN_LEVEL { get; set; }

    /// <summary>
    /// 1일때 초안작업자
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string isDesigner { get; set; } = null!;

    /// <summary>
    /// 1일때 해당 작업자 주문코렐 다운로드
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string isDown { get; set; } = null!;

    /// <summary>
    /// 1일때 외부 재택 작업자
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string isAlba { get; set; } = null!;

    /// <summary>
    /// 1일때 CS 콜센터
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string isCS { get; set; } = null!;

    /// <summary>
    /// 1일때 빠른손 로그인 가능
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string isDeveloper { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string? NState { get; set; }

    public byte? adLevel { get; set; }

    /// <summary>
    /// 1일때 재택/퀵 포장완료시  문자발송
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string? isPackingSMS { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? COMPANY_TYPE_CODE { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isViewNoticeYN { get; set; }

    [ForeignKey("COMPANY_SEQ")]
    [InverseProperty("ADMIN_LST")]
    public virtual COMPANY COMPANY_SEQNavigation { get; set; } = null!;
}
