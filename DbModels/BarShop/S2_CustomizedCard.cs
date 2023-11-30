using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class S2_CustomizedCard
{
    [Key]
    public int seq { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string custom_div { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? title { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? contents { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string image_small { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string image_big { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime reg_date { get; set; }
}
