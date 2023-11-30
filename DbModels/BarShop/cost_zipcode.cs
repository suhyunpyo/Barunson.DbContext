using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class cost_zipcode
{
    [Key]
    [StringLength(6)]
    [Unicode(false)]
    public string C_ZIPCODE { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? C_ZIPCODE_ADDR { get; set; }
}
