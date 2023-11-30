using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 이벤트게시판 아이템
/// </summary>
[MySqlCollation("utf8_unicode_ci")]
public partial class event_board_options
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    /// <summary>
    /// event_boards.id
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? event_board_id { get; set; }

    /// <summary>
    /// 옵션코드
    /// </summary>
    [StringLength(20)]
    public string? code { get; set; }

    /// <summary>
    /// 옵션명
    /// </summary>
    [StringLength(20)]
    public string? name { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }
}
