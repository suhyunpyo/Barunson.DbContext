using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class custom_order_plistSVG
{
    [Key]
    public int pid { get; set; }

    [Column(TypeName = "text")]
    public string svgData { get; set; } = null!;
}
