using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 하이모 이벤트
/// </summary>
[Keyless]
public partial class evt_himo_coupon
{
    [StringLength(50)]
    [Unicode(false)]
    public string uid { get; set; } = null!;

    [StringLength(15)]
    [Unicode(false)]
    public string hphone { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string coupon_code { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime create_Date { get; set; }
}
