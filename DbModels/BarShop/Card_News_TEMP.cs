using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class Card_News_TEMP
{
    [Key]
    public int seq { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string Kind { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string Img_Url { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string? View_YN { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string title { get; set; } = null!;

    [Column(TypeName = "ntext")]
    public string contents { get; set; } = null!;

    public int View_Cnt { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime reg_date { get; set; }

    public int? SortingNum { get; set; }
}
