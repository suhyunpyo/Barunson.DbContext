using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 마케팅동의로그
/// </summary>
public partial class marketing_agreement_log
{
    [Key]
    [Column(TypeName = "int(10)")]
    public int id { get; set; }

    /// <summary>
    /// 회원ID
    /// </summary>
    [Column(TypeName = "int(10) unsigned")]
    public uint? user_id { get; set; }

    /// <summary>
    /// 동의구분
    /// </summary>
    [StringLength(20)]
    [MySqlCollation("utf8_unicode_ci")]
    public string? agreement_type { get; set; }

    /// <summary>
    /// 동의스텝(M:회원가입,O:주문,S:샘플주문)
    /// </summary>
    [StringLength(1)]
    [MySqlCollation("utf8_unicode_ci")]
    public string? agreement_step { get; set; }

    /// <summary>
    /// 동의여부
    /// </summary>
    [StringLength(1)]
    [MySqlCollation("utf8_unicode_ci")]
    public string? chk_agreement { get; set; }

    /// <summary>
    /// 처리자ID
    /// </summary>
    [Column(TypeName = "int(10) unsigned")]
    public uint? admin_id { get; set; }

    /// <summary>
    /// 등록일시
    /// </summary>
    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }
}
