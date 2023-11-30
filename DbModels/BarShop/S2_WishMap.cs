using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class S2_WishMap
{
    [Key]
    public int seq { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string uid { get; set; } = null!;

    public int weddimg_idx { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? site_div { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime reg_date { get; set; }
}
