using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class dcake_address
{
    public int chain_code { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string branch { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string addr { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string phone { get; set; } = null!;
}
