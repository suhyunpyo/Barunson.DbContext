using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 샘플장관리(사용안함)
/// </summary>
[MySqlCollation("utf8_unicode_ci")]
public partial class sample_cabinet
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    /// <summary>
    /// 행번호 순서
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? col { get; set; }

    /// <summary>
    /// 열 열번호 : 1, 2, 3 ...
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? row { get; set; }

    /// <summary>
    /// 행 ip 주소 : 192.168.50.10
    /// </summary>
    [StringLength(15)]
    public string? ip_address { get; set; }

    /// <summary>
    /// 상품코드 : DDC_001
    /// </summary>
    [StringLength(15)]
    public string? code { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }
}
