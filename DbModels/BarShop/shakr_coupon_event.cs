using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 쉐이커 쿠폰 이벤트
/// </summary>
public partial class shakr_coupon_event
{
    [Key]
    public int seq { get; set; }

    [StringLength(255)]
    public string? coupon_seq { get; set; }

    [StringLength(255)]
    public string? company_seq { get; set; }

    [StringLength(255)]
    public string? id { get; set; }

    [StringLength(255)]
    public string? bhands_used { get; set; }

    [StringLength(255)]
    public string? shakr_used { get; set; }

    [StringLength(50)]
    public string? cp_price { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? cp_reg_date { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? cp_end_date { get; set; }

    [StringLength(255)]
    public string? temp1 { get; set; }

    [StringLength(255)]
    public string? temp2 { get; set; }
}
