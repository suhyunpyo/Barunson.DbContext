using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 카드 추가판 인사말 정보
/// </summary>
[Keyless]
public partial class custom_order_plistAddG
{
    public int pid { get; set; }

    /// <summary>
    /// 인사말
    /// </summary>
    [StringLength(4000)]
    public string? greeting_content { get; set; }

    [StringLength(4000)]
    public string? greeting_content2 { get; set; }
}
