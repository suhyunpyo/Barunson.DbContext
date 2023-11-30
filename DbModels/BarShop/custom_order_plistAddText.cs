using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[PrimaryKey("pid", "seq")]
public partial class custom_order_plistAddText
{
    [Key]
    public int pid { get; set; }

    [Key]
    public int seq { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? contents { get; set; }
}
