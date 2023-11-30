using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class S2_Accgr
{
    [StringLength(20)]
    [Unicode(false)]
    public string? gubun { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? gr_name { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? gr_gubun { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? item_code { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? name { get; set; }

    public int? price { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? default_1 { get; set; }
}
