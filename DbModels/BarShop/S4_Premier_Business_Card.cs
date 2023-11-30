using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// 예전모바일청첩장
/// </summary>
[Keyless]
public partial class S4_Premier_Business_Card
{
    public int seq { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? card_name { get; set; }

    public int? sorting_num { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? card_text { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? business_type { get; set; }
}
