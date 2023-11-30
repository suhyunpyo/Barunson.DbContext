using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[PrimaryKey("site_code", "prod_code")]
public partial class PHOTOBOOK_PROD_B2B
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string site_code { get; set; } = null!;

    [Key]
    [StringLength(15)]
    [Unicode(false)]
    public string prod_code { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string? prod_option { get; set; }

    public int prod_price { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime reg_date { get; set; }
}
