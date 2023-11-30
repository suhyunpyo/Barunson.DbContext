using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class CARD_JAEGO
{
    [Key]
    [StringLength(20)]
    [Unicode(false)]
    public string card_code { get; set; } = null!;

    public int jaego { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime reg_date { get; set; }
}
