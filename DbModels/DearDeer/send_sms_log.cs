using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// sms 전송로그
/// </summary>
[Index("recipients", Name = "recipients")]
[MySqlCollation("utf8_unicode_ci")]
public partial class send_sms_log
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    /// <summary>
    /// 전송
    /// </summary>
    [StringLength(100)]
    public string? recipients { get; set; }

    /// <summary>
    /// 메세지
    /// </summary>
    [Column(TypeName = "text")]
    public string? message { get; set; }

    /// <summary>
    /// 응답메세지
    /// </summary>
    [StringLength(50)]
    public string? result { get; set; }

    /// <summary>
    /// sms.id
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? sms_id { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? deleted_at { get; set; }
}
