using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
[Index("pid", Name = "IX_custom_order_plistAddG_backup_pid")]
public partial class custom_order_plistAddG_backup
{
    public int pid { get; set; }

    [StringLength(4000)]
    public string? greeting_content { get; set; }

    [StringLength(4000)]
    public string? greeting_content2 { get; set; }
}
