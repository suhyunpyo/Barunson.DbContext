using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 공통코드
/// </summary>
[PrimaryKey("code_group", "code")]
public partial class common_code
{
    /// <summary>
    /// 코드그룹
    /// </summary>
    [Key]
    [StringLength(20)]
    [MySqlCollation("utf8_unicode_ci")]
    public string code_group { get; set; } = null!;

    /// <summary>
    /// 코드그룹명
    /// </summary>
    [StringLength(50)]
    [MySqlCollation("utf8_unicode_ci")]
    public string? code_group_name { get; set; }

    /// <summary>
    /// 코드
    /// </summary>
    [Key]
    [StringLength(10)]
    [MySqlCollation("utf8_unicode_ci")]
    public string code { get; set; } = null!;

    /// <summary>
    /// 코드명
    /// </summary>
    [StringLength(50)]
    [MySqlCollation("utf8_unicode_ci")]
    public string? code_name { get; set; }

    /// <summary>
    /// 순서
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? sort { get; set; }

    /// <summary>
    /// 기타
    /// </summary>
    [StringLength(10)]
    [MySqlCollation("utf8_unicode_ci")]
    public string? etc1 { get; set; }

    /// <summary>
    /// 생성일시
    /// </summary>
    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    /// <summary>
    /// 수정일시
    /// </summary>
    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }

    /// <summary>
    /// 삭제일시
    /// </summary>
    [Column(TypeName = "timestamp")]
    public DateTime? deleted_at { get; set; }
}
