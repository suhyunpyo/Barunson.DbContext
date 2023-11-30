using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

[MySqlCollation("utf8_unicode_ci")]
public partial class sweetday_board
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    [Column(TypeName = "int(11)")]
    public int? user_id { get; set; }

    [StringLength(50)]
    public string? user_phone { get; set; }

    [StringLength(30)]
    public string? order_no { get; set; }

    [StringLength(20)]
    public string? user_name { get; set; }

    [StringLength(255)]
    public string? subject { get; set; }

    [Column(TypeName = "text")]
    public string? contents { get; set; }

    /// <summary>
    /// 노출상태(T:노출/F:숨김)
    /// </summary>
    [StringLength(1)]
    public string is_show { get; set; } = null!;

    /// <summary>
    /// T:베스트리뷰/F:일반리뷰
    /// </summary>
    [StringLength(1)]
    public string is_best { get; set; } = null!;

    /// <summary>
    /// sns 게시물 링크
    /// </summary>
    [StringLength(255)]
    public string? link { get; set; }

    [StringLength(255)]
    public string? sweetday_image01 { get; set; }

    [StringLength(255)]
    public string? sweetday_image02 { get; set; }

    [StringLength(255)]
    public string? sweetday_image03 { get; set; }

    /// <summary>
    /// T:쿠폰발급/F:쿠본미발급
    /// </summary>
    [StringLength(1)]
    public string issue_state { get; set; } = null!;

    [Column(TypeName = "text")]
    public string? reply { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? reply_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? deleted_at { get; set; }
}
