using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class DELIVERY_REG_LOG
{
    public int ID { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? USER_ID { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string CODE { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string CODE_NAME { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? REG_DATE { get; set; }
}
