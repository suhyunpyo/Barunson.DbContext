using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class tmp_order_flow_180314
{
    [StringLength(50)]
    [Unicode(false)]
    public string uid { get; set; } = null!;

    [StringLength(2)]
    [Unicode(false)]
    public string? 가입경로 { get; set; }

    public int total1 { get; set; }

    public int SB1 { get; set; }

    public int SA1 { get; set; }

    public int ST1 { get; set; }

    public int SS1 { get; set; }

    public int B1 { get; set; }

    public int ETC1 { get; set; }

    public int total2 { get; set; }

    public int SB2 { get; set; }

    public int SA2 { get; set; }

    public int ST2 { get; set; }

    public int SS2 { get; set; }

    public int B2 { get; set; }

    public int ETC2 { get; set; }
}
