using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 마케팅동의구분
/// </summary>
public partial class marketing_agreement_type
{
    /// <summary>
    /// 동의구분
    /// </summary>
    [Key]
    [StringLength(20)]
    [MySqlCollation("utf8_unicode_ci")]
    public string agreement_type { get; set; } = null!;

    /// <summary>
    /// 마케팅동의명칭
    /// </summary>
    [StringLength(50)]
    [MySqlCollation("utf8_unicode_ci")]
    public string? agreement_name { get; set; }

    /// <summary>
    /// 사용여부
    /// </summary>
    [StringLength(1)]
    [MySqlCollation("utf8_unicode_ci")]
    public string? is_use { get; set; }

    /// <summary>
    /// 시작일
    /// </summary>
    [StringLength(10)]
    [MySqlCollation("utf8_unicode_ci")]
    public string? started { get; set; }

    /// <summary>
    /// 종료일
    /// </summary>
    [StringLength(10)]
    [MySqlCollation("utf8_unicode_ci")]
    public string? ended { get; set; }

    /// <summary>
    /// 등록일시
    /// </summary>
    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    /// <summary>
    /// 수정일시
    /// </summary>
    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }
}
