using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class tEventBotTemplete
{
    [Key]
    public int BotIdx { get; set; }

    public int EventIdx { get; set; }

    public int BotOrderNo { get; set; }

    [StringLength(255)]
    [Unicode(false)]
    public string BotCopy { get; set; } = null!;

    [StringLength(255)]
    [Unicode(false)]
    public string BotBanner { get; set; } = null!;

    [StringLength(255)]
    [Unicode(false)]
    public string BotUrl { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string BotType { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string? addBtnYN { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? addBtnUrl { get; set; }

    [StringLength(5000)]
    [Unicode(false)]
    public string? BotNavi { get; set; }

    public int? BotReview { get; set; }

    public int? BotStock { get; set; }

    public int? BotSaleCnt { get; set; }
}
