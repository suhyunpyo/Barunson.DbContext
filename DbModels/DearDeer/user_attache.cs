using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// (사용안함)
/// </summary>
[MySqlCollation("utf8_unicode_ci")]
public partial class user_attache
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    /// <summary>
    /// 유저 아이디
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int user_id { get; set; }

    /// <summary>
    /// I: 이미지, F: 파일
    /// </summary>
    [StringLength(2)]
    public string type { get; set; } = null!;

    /// <summary>
    /// 원본파일
    /// </summary>
    [StringLength(255)]
    public string origin { get; set; } = null!;

    /// <summary>
    /// 썸네일파일
    /// </summary>
    [StringLength(255)]
    public string thumbnail { get; set; } = null!;

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? deleted_at { get; set; }
}
