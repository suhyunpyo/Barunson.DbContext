﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class S2_CardViewMerge
{
    [StringLength(1)]
    [Unicode(false)]
    public string isS2 { get; set; } = null!;

    public int card_seq { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? card_code { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string old_code { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? erp_code { get; set; }

    [StringLength(3)]
    [Unicode(false)]
    public string? card_div { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? card_image { get; set; }

    public int? card_price { get; set; }

    [StringLength(150)]
    [Unicode(false)]
    public string? card_name { get; set; }

    public short? brand { get; set; }

    [StringLength(152)]
    [Unicode(false)]
    public string? card_code_str { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string env_code { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string inpaper_code { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string? isHanji { get; set; }

    public int? master_2color { get; set; }

    public int isLaser { get; set; }
}
