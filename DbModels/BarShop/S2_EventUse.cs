using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class S2_EventUse
{
    [Key]
    public int charge_use_seq { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string event_name { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string charge_div { get; set; } = null!;
}
