using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class event_sale_carddiscount
{
    public int? card_seq { get; set; }

    public int? mincount { get; set; }

    public int? discount_rate { get; set; }
}
