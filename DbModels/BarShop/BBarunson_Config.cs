using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class BBarunson_Config
{
    [Key]
    public int id { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string clsControl_Use { get; set; } = null!;
}
