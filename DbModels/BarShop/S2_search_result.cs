using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class S2_search_result
{
    [StringLength(20)]
    public string? gubun { get; set; }

    public short? sort_order { get; set; }

    [StringLength(20)]
    public string? item_code { get; set; }
}
