using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[PrimaryKey("seq", "company_seq", "card_seq")]
public partial class Branch_special_discount_rate
{
    [Key]
    public int seq { get; set; }

    [Key]
    public int company_seq { get; set; }

    [Key]
    public int card_seq { get; set; }

    public double discount_rate { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime rdate { get; set; }
}
