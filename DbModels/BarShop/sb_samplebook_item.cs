using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class sb_samplebook_item
{
    [Key]
    public int seq { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? gubun { get; set; }

    [StringLength(30)]
    [Unicode(false)]
    public string? card_code { get; set; }

    public int? card_seq { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? ViewYN { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? sales_gubun { get; set; }
}
