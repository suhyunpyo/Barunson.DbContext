using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 고객센터 댓글
/// </summary>
[Index("contact_contents_id", Name = "contact_contents_id")]
[MySqlCollation("utf8_unicode_ci")]
public partial class contact_content_reply
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    /// <summary>
    /// 1:1게시판 아이디
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? contact_contents_id { get; set; }

    /// <summary>
    /// 댓글 부모아이디
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? parent_id { get; set; }

    /// <summary>
    /// 댓글 깊이
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? depth { get; set; }

    /// <summary>
    /// 사용자 아이디
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? user_id { get; set; }

    /// <summary>
    /// 사용자이름
    /// </summary>
    [StringLength(20)]
    public string? user_name { get; set; }

    /// <summary>
    /// 제목
    /// </summary>
    [StringLength(255)]
    public string? subject { get; set; }

    /// <summary>
    /// 리플 내용
    /// </summary>
    [Column(TypeName = "text")]
    public string? contents { get; set; }

    /// <summary>
    /// 패스워드
    /// </summary>
    [StringLength(255)]
    public string? password { get; set; }

    /// <summary>
    /// 첨부파일 링크
    /// </summary>
    [StringLength(255)]
    public string? attached { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? deleted_at { get; set; }
}
