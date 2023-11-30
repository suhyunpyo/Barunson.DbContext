using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 약도관리
/// </summary>
[MySqlCollation("utf8_unicode_ci")]
public partial class wedd_map
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    /// <summary>
    /// 예식장 이름
    /// </summary>
    [StringLength(100)]
    public string? wedd_name { get; set; }

    /// <summary>
    /// 주소1 지번주소
    /// </summary>
    [StringLength(255)]
    public string? wedd_addr1 { get; set; }

    /// <summary>
    /// 주소2 도로명주소
    /// </summary>
    [StringLength(255)]
    public string? wedd_addr2 { get; set; }

    /// <summary>
    /// 주소2 도로명주소
    /// </summary>
    [StringLength(100)]
    public string? wedd_phone { get; set; }

    /// <summary>
    /// 파일명
    /// </summary>
    [StringLength(255)]
    public string? wedd_prev { get; set; }

    [StringLength(255)]
    public string? wedd_indd { get; set; }

    [StringLength(255)]
    public string? wedd_pdf { get; set; }

    [StringLength(255)]
    public string? wedd_ai { get; set; }

    /// <summary>
    /// 인기쟁이
    /// </summary>
    [Column(TypeName = "tinyint(4)")]
    public sbyte is_popular { get; set; }

    /// <summary>
    /// COREL TO AI 변환 에러 , 0: 정상, 1:에러
    /// </summary>
    [Column(TypeName = "tinyint(4)")]
    public sbyte is_convert_error { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte is_show { get; set; }

    [Column(TypeName = "tinyint(4)")]
    public sbyte owner_id { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }
}
