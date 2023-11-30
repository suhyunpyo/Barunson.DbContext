using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[PrimaryKey("Company_Seq", "card_seq")]
public partial class S2_CardSalesBest
{
    [Key]
    public int Company_Seq { get; set; }

    [Key]
    public int card_seq { get; set; }

    public short? Ranking_w { get; set; }

    public short? Ranking_m { get; set; }

    public short? NewProduct { get; set; }

    public short? SpecialPrice { get; set; }

    public short? BestWeek { get; set; }

    public short? BestMonth { get; set; }
}
