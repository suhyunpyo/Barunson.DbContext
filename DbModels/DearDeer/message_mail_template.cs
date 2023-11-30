using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// email
/// </summary>
[MySqlCollation("utf8_unicode_ci")]
public partial class message_mail_template
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    /// <summary>
    /// 메일 제목
    /// </summary>
    [StringLength(255)]
    public string? mail_subject { get; set; }

    /// <summary>
    /// 메일 내용
    /// </summary>
    [Column(TypeName = "text")]
    public string? body { get; set; }

    /// <summary>
    /// 보내는 사람 메일주소
    /// </summary>
    [StringLength(50)]
    public string? sender { get; set; }

    /// <summary>
    /// 보내는사람이름
    /// </summary>
    [StringLength(50)]
    public string? sender_name { get; set; }

    /// <summary>
    /// 다이렉트센드 아이디
    /// </summary>
    [StringLength(50)]
    public string? directsend_id { get; set; }

    /// <summary>
    /// 다이렉트센드 아이디
    /// </summary>
    [StringLength(255)]
    public string? return_url { get; set; }

    /// <summary>
    /// 수신동의 설명
    /// </summary>
    [Column(TypeName = "text")]
    public string? agreement_text { get; set; }

    /// <summary>
    /// 수신안함 설명
    /// </summary>
    [Column(TypeName = "text")]
    public string? deny_text { get; set; }

    /// <summary>
    /// 보내는 사람 정보
    /// </summary>
    [StringLength(255)]
    public string? sender_info_text { get; set; }

    /// <summary>
    /// logo 사용:1, 사용안함:0
    /// </summary>
    [StringLength(1)]
    public string logo_state { get; set; } = null!;

    /// <summary>
    /// 로고패스
    /// </summary>
    [StringLength(255)]
    public string? logo_path { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }
}
