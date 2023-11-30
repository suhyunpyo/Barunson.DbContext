using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Table("TB_PRODUCT_SIZE", Schema = "invtmng")]
public partial class TB_PRODUCT_SIZE
{
    [Key]
    public int PS_IDX { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string PAGE_NUMBER { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string SIZE { get; set; } = null!;

    [StringLength(14)]
    [Unicode(false)]
    public string WH { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? COVER_NAME { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string? COVER_GROUP { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? INFOMATION { get; set; }

    [StringLength(4)]
    [Unicode(false)]
    public string PAPER_CODE { get; set; } = null!;

    [StringLength(200)]
    [Unicode(false)]
    public string? IMAGE_INFO { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? ETC { get; set; }
}
