using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class coupon_complete_error_message
{
    public int? order_seq { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? error_mssage { get; set; }
}
