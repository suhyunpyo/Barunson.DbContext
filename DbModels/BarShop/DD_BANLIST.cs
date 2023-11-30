using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class DD_BANLIST
{
    [Key]
    public int seq { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string hphone { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime regdate { get; set; }
}
