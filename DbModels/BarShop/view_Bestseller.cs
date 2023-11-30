using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class view_Bestseller
{
    [StringLength(1)]
    [Unicode(false)]
    public string sales_gubun { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string? gubun { get; set; }

    public int? card_seq { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string card_code { get; set; } = null!;

    public short? company { get; set; }

    public int card_price_customer { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? disrate_type { get; set; }

    public byte? card_kind { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? card_img_ms { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? regdate { get; set; }
}
