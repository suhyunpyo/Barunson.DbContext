using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class CARD_SEASON_STYLEITEM
{
    [Key]
    public int cardstyle_seq { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? cardstyle_num { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? cardstyle_str { get; set; }
}
