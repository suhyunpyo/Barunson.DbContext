using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class tEventBotItem
{
    public int BotItemIdx { get; set; }

    public int BotIdx { get; set; }

    public int EventIdx { get; set; }

    [StringLength(12)]
    [Unicode(false)]
    public string BotItemCD { get; set; } = null!;

    public int BotOrderNo { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string BotSize { get; set; } = null!;
}
