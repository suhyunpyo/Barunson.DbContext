using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class drop_invo_area
{
    [Key]
    public int id { get; set; }

    [StringLength(100)]
    public string addr { get; set; } = null!;
}
