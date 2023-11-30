using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 투인원 할인율관리
/// </summary>
[MySqlCollation("utf8_unicode_ci")]
public partial class site_policy_benefit
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    /// <summary>
    /// site_policy.id
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int site_policy_id { get; set; }

    [StringLength(10)]
    public string? product_type { get; set; }

    [Column(TypeName = "int(11)")]
    public int count { get; set; }

    [Column(TypeName = "int(11)")]
    public int benefit_price { get; set; }

    [Column(TypeName = "int(10) unsigned")]
    public uint? use_available_min_cnt { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }
}
