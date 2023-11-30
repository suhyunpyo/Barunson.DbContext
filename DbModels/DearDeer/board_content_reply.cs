using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 게시물 리플
/// </summary>
[MySqlCollation("utf8_unicode_ci")]
public partial class board_content_reply
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    /// <summary>
    /// board_contents.id
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int board_contents_id { get; set; }

    /// <summary>
    /// board_content_reply.id
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? parent_id { get; set; }

    /// <summary>
    /// 리플 깊이
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? depth { get; set; }

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
    /// 리플제목
    /// </summary>
    [StringLength(255)]
    public string? subject { get; set; }

    /// <summary>
    /// 내용
    /// </summary>
    [Column(TypeName = "text")]
    public string? content { get; set; }

    /// <summary>
    /// 비밀번호
    /// </summary>
    [StringLength(255)]
    public string? password { get; set; }

    /// <summary>
    /// 정렬
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? sort_order { get; set; }

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
