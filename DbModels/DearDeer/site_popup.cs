using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 메인 팝업
/// </summary>
[MySqlCollation("utf8_unicode_ci")]
public partial class site_popup
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    /// <summary>
    /// 팝업명
    /// </summary>
    [StringLength(255)]
    public string? popup_name { get; set; }

    /// <summary>
    /// 팝업설명
    /// </summary>
    [StringLength(255)]
    public string? popup_desc { get; set; }

    /// <summary>
    /// 노출상태
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int state { get; set; }

    /// <summary>
    /// 브라우저 좌표 x
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int position_left { get; set; }

    /// <summary>
    /// 브라우저 좌표 y
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int position_top { get; set; }

    /// <summary>
    /// 팝업가로크기
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int size_width { get; set; }

    /// <summary>
    /// 팝업세로크기
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int size_height { get; set; }

    /// <summary>
    /// 작성자
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int owner_id { get; set; }

    /// <summary>
    /// 수정자
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int updater_id { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }
}
