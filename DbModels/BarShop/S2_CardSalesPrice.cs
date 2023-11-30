using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[PrimaryKey("card_seq", "company_seq")]
public partial class S2_CardSalesPrice
{
    [Key]
    public int card_seq { get; set; }

    [Key]
    public int company_seq { get; set; }

    public int card_price { get; set; }

    public int id { get; set; }
}
