using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class LOGO_CATEGORY
{
    public int id { get; set; }

    [Key]
    [StringLength(2)]
    [Unicode(false)]
    public string lcategory { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? categoryName { get; set; }
}
