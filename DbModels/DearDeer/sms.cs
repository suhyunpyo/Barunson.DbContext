using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// sms 템플릿
/// </summary>
[Index("sms_code", Name = "sms_sms_code_unique", IsUnique = true)]
[MySqlCollation("utf8_unicode_ci")]
public partial class sms
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    /// <summary>
    /// sms 코드
    /// </summary>
    [StringLength(20)]
    public string sms_code { get; set; } = null!;

    /// <summary>
    /// sms 섹션
    /// </summary>
    [StringLength(255)]
    public string? sms_section { get; set; }

    /// <summary>
    /// sms 설명
    /// </summary>
    [StringLength(255)]
    public string? sms_desc { get; set; }

    /// <summary>
    /// sms 내용
    /// </summary>
    [StringLength(255)]
    public string? sms_message { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? deleted_at { get; set; }
}
