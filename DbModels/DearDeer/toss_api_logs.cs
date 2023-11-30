using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.DearDeer;

/// <summary>
/// 토스 API 로그(사용안함)
/// </summary>
[MySqlCollation("utf8_unicode_ci")]
public partial class toss_api_logs
{
    [Key]
    [Column(TypeName = "int(10) unsigned")]
    public uint id { get; set; }

    /// <summary>
    /// uuid
    /// </summary>
    [StringLength(50)]
    public string? uuid { get; set; }

    /// <summary>
    /// uuid
    /// </summary>
    [StringLength(50)]
    public string? mcard_code { get; set; }

    /// <summary>
    /// order_item_no
    /// </summary>
    [Column(TypeName = "text")]
    public string? url { get; set; }

    /// <summary>
    /// remote_address
    /// </summary>
    [StringLength(30)]
    public string? remote_addr { get; set; }

    /// <summary>
    /// user_agent
    /// </summary>
    [StringLength(255)]
    public string? user_agent { get; set; }

    [StringLength(255)]
    public string? api_result { get; set; }

    [StringLength(255)]
    public string? groom_link { get; set; }

    [StringLength(255)]
    public string? bride_link { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "timestamp")]
    public DateTime? updated_at { get; set; }
}
