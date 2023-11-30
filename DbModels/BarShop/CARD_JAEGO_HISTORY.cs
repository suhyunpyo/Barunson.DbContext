using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class CARD_JAEGO_HISTORY
{
    [StringLength(20)]
    [Unicode(false)]
    public string card_code { get; set; } = null!;

    public int chnum { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? chcomment { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime reg_date { get; set; }

    public int? order_seq { get; set; }

    [Key]
    public int seq { get; set; }

    public int? now_jaego { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? admin_id { get; set; }
}
