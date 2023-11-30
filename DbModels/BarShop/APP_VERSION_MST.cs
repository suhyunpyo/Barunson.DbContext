using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class APP_VERSION_MST
{
    [Key]
    public int SEQ { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? DEVICE_TYPE_CODE { get; set; }

    public int? VERSION { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? REG_DATE { get; set; }
}
