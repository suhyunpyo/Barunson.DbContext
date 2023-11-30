using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class ewed_order_detail_B
{
    [Key]
    public int order_seq { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? basic_photo { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? aboutMan { get; set; }

    [StringLength(500)]
    [Unicode(false)]
    public string? aboutWoman { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? Mannam { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string? Mirae { get; set; }
}
