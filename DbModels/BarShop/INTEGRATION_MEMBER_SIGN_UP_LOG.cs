using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 통합아이디 회원가입 액션 로그
/// </summary>
public partial class INTEGRATION_MEMBER_SIGN_UP_LOG
{
    [Key]
    public int SEQ { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? SALES_GUBUN { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? USER_ID { get; set; }

    /// <summary>
    /// 통합아이디
    /// </summary>
    [StringLength(50)]
    [Unicode(false)]
    public string? INTEGRATION_USER_ID { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? USER_TABLE_NAME { get; set; }

    /// <summary>
    /// 접근 사이트
    /// </summary>
    [StringLength(100)]
    [Unicode(false)]
    public string? REFERER_SITE { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? REFERER_SALES_GUBUN { get; set; }

    /// <summary>
    /// 선택 사이트
    /// </summary>
    [StringLength(100)]
    [Unicode(false)]
    public string? SELECT_SITE { get; set; }

    /// <summary>
    /// 선택 ID
    /// </summary>
    [StringLength(100)]
    [Unicode(false)]
    public string? SELECT_ID { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? REG_DATE { get; set; }
}
