using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 이메일관리
/// </summary>
[Index("email_code", Name = "email_email_code_unique", IsUnique = true)]
[MySqlCollation("utf8_unicode_ci")]
public partial class email
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    /// <summary>
    /// 작성자
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int owner_id { get; set; }

    /// <summary>
    /// email 코드
    /// </summary>
    [StringLength(20)]
    public string? email_code { get; set; }

    /// <summary>
    /// email 섹션
    /// </summary>
    [StringLength(255)]
    public string? email_section { get; set; }

    /// <summary>
    /// email 설명
    /// </summary>
    [StringLength(255)]
    public string? email_desc { get; set; }

    /// <summary>
    /// email 제목
    /// </summary>
    [StringLength(100)]
    public string? subject { get; set; }

    /// <summary>
    /// email 내용
    /// </summary>
    [Column(TypeName = "text")]
    public string? body { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? deleted_at { get; set; }
}
