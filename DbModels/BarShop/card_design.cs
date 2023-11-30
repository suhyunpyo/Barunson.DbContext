using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class card_design
{
    [Key]
    [StringLength(50)]
    [Unicode(false)]
    public string card_code { get; set; } = null!;

    public int pagesizeW { get; set; }

    public int pagesizeH { get; set; }

    /// <summary>
    /// 1:기본,2:특이
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string design_type { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string isFPrint { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string isMapFPrint { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string isBackground { get; set; } = null!;
}
