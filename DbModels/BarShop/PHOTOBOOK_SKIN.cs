using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class PHOTOBOOK_SKIN
{
    [Key]
    public int id { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string skin_code { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? skin_fn { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string prod_cate { get; set; } = null!;

    public short? skin_page { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string? prod_size { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? description { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? img1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? img2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? img3 { get; set; }
}
