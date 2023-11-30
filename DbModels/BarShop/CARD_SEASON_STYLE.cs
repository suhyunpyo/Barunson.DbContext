using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class CARD_SEASON_STYLE
{
    [Key]
    public int seq { get; set; }

    public int? cardstyle_seq { get; set; }

    public int? card_seq { get; set; }
}
