using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 할로윈 이벤트
/// </summary>
public partial class S4_Event_Halloween
{
    [Key]
    public int event_seq { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? uid { get; set; }

    public int? company_seq { get; set; }

    public short? random_count { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? reg_date { get; set; }

    public short? run_status { get; set; }

    public short? halloween_count { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? coupon_number { get; set; }

    public short? coupon_count { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? coupon_reg_date { get; set; }
}
