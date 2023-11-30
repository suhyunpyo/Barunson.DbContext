using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class S2_MediaView
{
    [Key]
    public int seq { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string sales_gubun { get; set; } = null!;

    public int company_seq { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? writer { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string title { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? user_img1 { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? user_img2 { get; set; }

    public int viewcnt { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string viewdiv { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? start_date { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? end_date { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime reg_date { get; set; }
}
