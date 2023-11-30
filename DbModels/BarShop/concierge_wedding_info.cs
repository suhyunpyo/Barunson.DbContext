using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class concierge_wedding_info
{
    public int order_seq { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string wedd_day { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string whall_gubun { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string whall_name { get; set; } = null!;

    [StringLength(400)]
    public string whall_address { get; set; } = null!;
}
