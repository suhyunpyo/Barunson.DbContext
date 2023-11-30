using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class sticker_count
{
    [StringLength(50)]
    [Unicode(false)]
    public string card_code { get; set; } = null!;

    public int item_count { get; set; }
}
