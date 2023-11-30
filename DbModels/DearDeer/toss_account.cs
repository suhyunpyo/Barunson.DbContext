using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 토스 축의금송금 계정(사용안함)
/// </summary>
[MySqlCollation("utf8_unicode_ci")]
public partial class toss_account
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    /// <summary>
    /// 타겟
    /// </summary>
    [StringLength(20)]
    public string? target { get; set; }

    [StringLength(50)]
    public string? uuid { get; set; }

    /// <summary>
    /// 타겟.id
    /// </summary>
    [Column(TypeName = "int(11)")]
    public int? target_id { get; set; }

    /// <summary>
    /// 받는분
    /// </summary>
    [StringLength(20)]
    public string? toss_owner1 { get; set; }

    [StringLength(20)]
    public string? toss_owner2 { get; set; }

    /// <summary>
    /// 받는분은행
    /// </summary>
    [StringLength(10)]
    public string? toss_bank1 { get; set; }

    [StringLength(10)]
    public string? toss_bank2 { get; set; }

    /// <summary>
    /// 받는분 계좌
    /// </summary>
    [StringLength(50)]
    public string? toss_bankaccount1 { get; set; }

    [StringLength(50)]
    public string? toss_bankaccount2 { get; set; }

    [StringLength(255)]
    public string? groom_link { get; set; }

    [StringLength(255)]
    public string? bride_link { get; set; }

    [StringLength(50)]
    public string? couple_key { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? deleted_at { get; set; }
}
