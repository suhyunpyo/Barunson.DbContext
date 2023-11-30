using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 인터파크 쿠폰 이벤트
/// </summary>
public partial class interparktour_coupon_event
{
    [StringLength(255)]
    public string? coupon_seq { get; set; }

    [StringLength(255)]
    public string? used { get; set; }

    [StringLength(255)]
    public string? company_seq { get; set; }

    [StringLength(255)]
    public string? id { get; set; }

    [Key]
    public int seq { get; set; }
}
