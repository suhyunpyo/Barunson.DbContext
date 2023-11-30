using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// oauth 관리
/// </summary>
[MySqlCollation("utf8_unicode_ci")]
public partial class thirdparty_oauth
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    /// <summary>
    /// 회사
    /// </summary>
    [StringLength(30)]
    public string? type { get; set; }

    /// <summary>
    /// 암호화타입
    /// </summary>
    [StringLength(30)]
    public string? encrypt { get; set; }

    /// <summary>
    /// 기본url
    /// </summary>
    [StringLength(100)]
    public string? base_url { get; set; }

    [StringLength(100)]
    public string? uri { get; set; }

    /// <summary>
    /// accessKey
    /// </summary>
    [StringLength(100)]
    public string? accessKey { get; set; }

    /// <summary>
    /// secretKey
    /// </summary>
    [StringLength(100)]
    public string? secretKey { get; set; }

    /// <summary>
    /// accessToken
    /// </summary>
    [StringLength(100)]
    public string? accessToken { get; set; }

    /// <summary>
    /// refreshToken
    /// </summary>
    [StringLength(100)]
    public string? refreshToken { get; set; }

    /// <summary>
    /// expireToken
    /// </summary>
    [StringLength(100)]
    public string? expireToken { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? deleted_at { get; set; }
}
