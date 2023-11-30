using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// email 전송로그
/// </summary>
[Index("recipients", Name = "send_email_log_recipients_index")]
[MySqlCollation("utf8_unicode_ci")]
public partial class send_email_log
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    /// <summary>
    /// 발송 email
    /// </summary>
    [StringLength(100)]
    public string? recipients { get; set; }

    /// <summary>
    /// 제목
    /// </summary>
    [StringLength(100)]
    public string? subject { get; set; }

    /// <summary>
    /// 내용
    /// </summary>
    [Column(TypeName = "text")]
    public string? body { get; set; }

    /// <summary>
    /// 응답메세지
    /// </summary>
    [StringLength(50)]
    public string? result { get; set; }

    /// <summary>
    /// email.id
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? email_id { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }
}
