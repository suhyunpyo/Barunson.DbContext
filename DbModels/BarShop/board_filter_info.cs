using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class board_filter_info
{
    public int code { get; set; }

    [StringLength(1)]
    public string? protect { get; set; }

    [StringLength(1)]
    public string? my_cnt { get; set; }

    [StringLength(250)]
    public string? filter { get; set; }
}
