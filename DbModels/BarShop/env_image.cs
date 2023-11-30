using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class env_image
{
    [StringLength(30)]
    [Unicode(false)]
    public string card_code { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string style_gb { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string? etc_memo { get; set; }
}
