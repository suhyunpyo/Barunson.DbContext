using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class S2_CardDigitalColor
{
    [Key]
    [StringLength(2)]
    [Unicode(false)]
    public string color_code { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string color_name { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? color_image { get; set; }
}
