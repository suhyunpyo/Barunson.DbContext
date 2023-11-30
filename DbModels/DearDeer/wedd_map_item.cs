using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 약도 상세
/// </summary>
[MySqlCollation("utf8_unicode_ci")]
public partial class wedd_map_item
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    /// <summary>
    /// wedd_map.id
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int wedd_map_id { get; set; }

    /// <summary>
    /// 예식장 지도 PNG
    /// </summary>
    [StringLength(255)]
    public string? item_png { get; set; }

    /// <summary>
    /// 예식장 지도 INDD
    /// </summary>
    [StringLength(255)]
    public string? item_indd { get; set; }

    [StringLength(255)]
    public string? item_pdf { get; set; }

    [StringLength(255)]
    public string? item_ai { get; set; }

    /// <summary>
    /// 예식장 설명
    /// </summary>
    [Column(TypeName = "text")]
    public string? item_desc { get; set; }

    /// <summary>
    /// 지도 가로크기
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? item_width { get; set; }

    /// <summary>
    /// 지도 세로크기
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? item_height { get; set; }

    [Column(TypeName = "text")]
    public string? road_full_text { get; set; }

    /// <summary>
    /// 교통편1
    /// </summary>
    [StringLength(50)]
    public string? road_name1 { get; set; }

    /// <summary>
    /// 교통편1 상세
    /// </summary>
    [Column(TypeName = "text")]
    public string? road_value1 { get; set; }

    /// <summary>
    /// 교통편2
    /// </summary>
    [StringLength(50)]
    public string? road_name2 { get; set; }

    /// <summary>
    /// 교통편2 상세
    /// </summary>
    [Column(TypeName = "text")]
    public string? road_value2 { get; set; }

    /// <summary>
    /// 교통편3
    /// </summary>
    [StringLength(50)]
    public string? road_name3 { get; set; }

    /// <summary>
    /// 교통편3 상세
    /// </summary>
    [Column(TypeName = "text")]
    public string? road_value3 { get; set; }

    /// <summary>
    /// 교통편4
    /// </summary>
    [StringLength(50)]
    public string? road_name4 { get; set; }

    /// <summary>
    /// 교통편4 상세
    /// </summary>
    [Column(TypeName = "text")]
    public string? road_value4 { get; set; }

    /// <summary>
    /// 교통편5
    /// </summary>
    [StringLength(50)]
    public string? road_name5 { get; set; }

    /// <summary>
    /// 교통편5 상세
    /// </summary>
    [Column(TypeName = "text")]
    public string? road_value5 { get; set; }

    [Column(TypeName = "int(11)")]
    public int? sort_order { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }
}
