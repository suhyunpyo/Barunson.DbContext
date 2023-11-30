using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
[Index("pid", Name = "IX_custom_order_plistAddT_backup_pid")]
public partial class custom_order_plistAddT_backup
{
    public int id { get; set; }

    [StringLength(6)]
    [Unicode(false)]
    public string? ttype { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? title { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? contents { get; set; }

    public int pid { get; set; }
}
