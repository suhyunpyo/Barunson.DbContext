using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class DELIVERY_CODE
{
    public int ID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string CODE { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string CODE_NAME { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string? USE_YN { get; set; }
}
