using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[PrimaryKey("prod_id", "prod_option")]
public partial class PHOTOBOOK_PROD_OPTION
{
    [Key]
    public int prod_id { get; set; }

    [Key]
    public short prod_option { get; set; }

    public int add_price { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? tmp1 { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? mc_prod_name { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? mc_prod_img { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? pn { get; set; }

    public short? p { get; set; }
}
