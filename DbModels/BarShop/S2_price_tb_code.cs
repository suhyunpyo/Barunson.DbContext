﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class S2_price_tb_code
{
    [StringLength(20)]
    public string? price_code { get; set; }

    public float? P_50 { get; set; }

    public float? P_100 { get; set; }

    public float? P_150 { get; set; }

    public float? P_200 { get; set; }

    public float? P_250 { get; set; }

    public float? P_300 { get; set; }

    public float? P_350 { get; set; }

    public float? P_400 { get; set; }

    public float? P_450 { get; set; }

    public float? P_500 { get; set; }

    public float? P_550 { get; set; }

    public float? P_600 { get; set; }

    public float? P_650 { get; set; }

    public float? P_700 { get; set; }

    public float? P_800 { get; set; }

    public float? P_900 { get; set; }

    public float? P_1000 { get; set; }
}
