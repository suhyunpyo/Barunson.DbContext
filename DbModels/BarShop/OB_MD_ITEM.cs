using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class OB_MD_ITEM
{
    [Key]
    public int SEQ { get; set; }

    public int? CARD_SEQ { get; set; }

    public int? RANK { get; set; }
}
