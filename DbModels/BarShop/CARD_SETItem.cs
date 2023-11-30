using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[PrimaryKey("set_seq", "card_seq")]
public partial class CARD_SETItem
{
    [Key]
    public int set_seq { get; set; }

    [Key]
    public int card_seq { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime reg_date { get; set; }
}
