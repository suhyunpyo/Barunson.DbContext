using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class S2_Acc
{
    [StringLength(20)]
    [Unicode(false)]
    public string? gubun { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? brand { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? item_code { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? erp_code { get; set; }

    public int? price { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? size { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? sex { get; set; }

    [StringLength(100)]
    public string? comment { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? image { get; set; }
}
