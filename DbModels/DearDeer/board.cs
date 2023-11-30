using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 게시판관리
/// </summary>
[MySqlCollation("utf8_unicode_ci")]
public partial class board
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    /// <summary>
    /// 게시판 이름
    /// </summary>
    [StringLength(100)]
    public string? name { get; set; }

    /// <summary>
    /// 설명
    /// </summary>
    [StringLength(255)]
    public string? desc { get; set; }

    /// <summary>
    /// 1:공지사항, 2:일반게시판, 3:고객센터
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int type { get; set; }

    /// <summary>
    /// 만든사람
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int owner_id { get; set; }

    /// <summary>
    /// 수정한사람
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int updater_id { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }
}
