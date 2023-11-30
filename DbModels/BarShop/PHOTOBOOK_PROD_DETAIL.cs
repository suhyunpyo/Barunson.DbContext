using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
[Table("PHOTOBOOK_PROD_DETAIL", Schema = "invtmng")]
public partial class PHOTOBOOK_PROD_DETAIL
{
    [StringLength(1)]
    [Unicode(false)]
    public string site_code { get; set; } = null!;

    public int? prod_id { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string isDP { get; set; } = null!;

    [Column(TypeName = "text")]
    public string? prod_description { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? img_b1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? img_b2 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? img_b3 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? img_b4 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? img_b5 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? img_b6 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? img_b7 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? img_b8 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? img_b9 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? img_b10 { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? reg_date { get; set; }
}
