using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class evt_memoerybook_gift
{
    [StringLength(20)]
    [Unicode(false)]
    public string gift_card_code { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string card_code { get; set; } = null!;
}
