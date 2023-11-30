using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

[MySqlCollation("utf8_unicode_ci")]
public partial class search_word
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    /// <summary>
    /// 키워드
    /// </summary>
    [StringLength(100)]
    public string? keyword { get; set; }

    /// <summary>
    /// 이동경로 url
    /// </summary>
    [StringLength(200)]
    public string? link_url { get; set; }

    /// <summary>
    /// _self : 본창 / _blank : 새창 이동 
    /// </summary>
    [StringLength(10)]
    public string target { get; set; } = null!;

    /// <summary>
    /// 폰트색
    /// </summary>
    [StringLength(10)]
    public string? color_font { get; set; }

    /// <summary>
    /// F: 사용안함, T: 사용 함
    /// </summary>
    [StringLength(1)]
    public string? is_display { get; set; }

    /// <summary>
    /// 정렬
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int sort_order { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }

    /// <summary>
    /// F: 사용안함, T: 사용 함 검색 타이틀여부 
    /// </summary>
    [StringLength(1)]
    public string? is_main { get; set; }
}
