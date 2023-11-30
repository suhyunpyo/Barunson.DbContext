using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class jehucoupon_noCard
{
    [StringLength(30)]
    [Unicode(false)]
    public string card_code { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string sales_gubun { get; set; } = null!;
}
