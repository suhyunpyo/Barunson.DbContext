using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class event_CardDiscount
{
    public int card_Seq { get; set; }

    public int card_count { get; set; }

    public int DISCOUNT_rate { get; set; }
}
