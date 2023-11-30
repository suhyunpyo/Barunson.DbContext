using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class S2_CardSamplePrice
{
    [Key]
    public int id { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string site_gubun { get; set; } = null!;

    [StringLength(3)]
    [Unicode(false)]
    public string price_type { get; set; } = null!;

    public int price { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string updater { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? created_at { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? updated_at { get; set; }
}
