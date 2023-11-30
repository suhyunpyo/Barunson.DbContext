using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// faq 게시물
/// </summary>
[MySqlCollation("utf8_unicode_ci")]
public partial class faq_board_contents
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    /// <summary>
    /// 자주묻는 질문 게시판 ID
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int faq_board_id { get; set; }

    /// <summary>
    /// 자주묻는 질문 제목
    /// </summary>
    [StringLength(255)]
    public string subject { get; set; } = null!;

    /// <summary>
    /// 자주묻는 질문 내용
    /// </summary>
    [Column(TypeName = "text")]
    public string contents { get; set; } = null!;

    /// <summary>
    /// 순번
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int sort_order { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? deleted_at { get; set; }
}
