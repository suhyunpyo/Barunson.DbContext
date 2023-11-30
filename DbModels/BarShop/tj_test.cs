using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class tj_test
{
    [Key]
    public int id { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? name { get; set; }
}
