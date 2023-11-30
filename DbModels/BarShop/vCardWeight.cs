using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class vCardWeight
{
    public int CARD_SEQ { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string card_code { get; set; } = null!;

    public double card_weight { get; set; }
}
