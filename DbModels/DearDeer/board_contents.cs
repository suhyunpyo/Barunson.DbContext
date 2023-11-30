using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 게시판의 게시물
/// </summary>
[MySqlCollation("utf8_unicode_ci")]
public partial class board_contents
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    /// <summary>
    /// board.id
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int board_id { get; set; }

    /// <summary>
    /// users.id
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? user_id { get; set; }

    /// <summary>
    /// users.name
    /// </summary>
    [StringLength(255)]
    public string? user_name { get; set; }

    /// <summary>
    /// 제목
    /// </summary>
    [StringLength(255)]
    public string? subject { get; set; }

    /// <summary>
    /// 내용
    /// </summary>
    [Column(TypeName = "text")]
    public string? contents { get; set; }

    /// <summary>
    /// 비밀번호
    /// </summary>
    [StringLength(255)]
    public string? password { get; set; }

    /// <summary>
    /// 첨부파일
    /// </summary>
    [StringLength(255)]
    public string? attached { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }
}
