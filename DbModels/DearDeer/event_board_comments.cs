using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 이벤트 게시판 게시글
/// </summary>
[Index("event_board_id", "notice", "deleted_at", Name = "idx_board")]
[Index("user_id", Name = "idx_user_id")]
[MySqlCollation("utf8_unicode_ci")]
public partial class event_board_comments
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    /// <summary>
    /// event_board.id
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? event_board_id { get; set; }

    /// <summary>
    /// 작성자 아이디
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? user_id { get; set; }

    [StringLength(255)]
    public string? user_phone { get; set; }

    [StringLength(1)]
    public string? link_type { get; set; }

    /// <summary>
    /// 작성자 이름
    /// </summary>
    [StringLength(50)]
    public string? user_name { get; set; }

    /// <summary>
    /// 링크
    /// </summary>
    [StringLength(255)]
    public string link { get; set; } = null!;

    [StringLength(1)]
    public string? notice { get; set; }

    /// <summary>
    /// 제목 명
    /// </summary>
    [StringLength(255)]
    public string subject { get; set; } = null!;

    /// <summary>
    /// 내용
    /// </summary>
    [Column(TypeName = "text")]
    public string? contents { get; set; }

    /// <summary>
    /// 옵션코드
    /// </summary>
    [StringLength(30)]
    public string? option_code { get; set; }

    [StringLength(1)]
    public string issue_state { get; set; } = null!;

    [Column(TypeName = "text")]
    public string? memo { get; set; }

    [StringLength(1)]
    public string is_auto_pass { get; set; } = null!;

    [Column(TypeName = "text")]
    public string? auto_pass_contents { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? memo_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? deleted_at { get; set; }
}
