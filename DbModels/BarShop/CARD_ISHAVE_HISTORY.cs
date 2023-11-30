using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class CARD_ISHAVE_HISTORY
{
    [Key]
    public int id { get; set; }

    public int card_seq { get; set; }

    public int ishave_change { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? description { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? admin_id { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? reg_date { get; set; }
}
