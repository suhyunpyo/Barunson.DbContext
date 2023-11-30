using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// indd 라벨관리 (사용안함)
/// </summary>
[MySqlCollation("utf8_unicode_ci")]
public partial class link_indd_order_variable
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    [StringLength(50)]
    public string? indd_key { get; set; }

    /// <summary>
    /// 인디자인 라벨
    /// </summary>
    [StringLength(50)]
    public string? indd_label { get; set; }

    /// <summary>
    /// 인디자인 타입(청첩장:cont, 봉투:env)
    /// </summary>
    [StringLength(50)]
    public string? indd_type { get; set; }

    /// <summary>
    /// 주문아이템 타입(청첩장:cont, 봉투:env)
    /// </summary>
    [StringLength(50)]
    public string? item_type { get; set; }

    /// <summary>
    /// 주문 아이템 키
    /// </summary>
    [StringLength(50)]
    public string? item_key { get; set; }

    [StringLength(255)]
    public string? default_value { get; set; }

    /// <summary>
    /// 변수 설명
    /// </summary>
    [Column(TypeName = "text")]
    public string? variable_desc { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }
}
