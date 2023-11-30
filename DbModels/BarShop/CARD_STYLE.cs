using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class CARD_STYLE
{
    [Key]
    public int style_seq { get; set; }

    public int up_style_seq { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string style_name { get; set; } = null!;
}
