using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[PrimaryKey("uid", "view_date", "card_seq")]
public partial class S5_TodayViewItems
{
    public int seq { get; set; }

    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string uid { get; set; } = null!;

    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string view_date { get; set; } = null!;

    [Key]
    public int card_seq { get; set; }
}
