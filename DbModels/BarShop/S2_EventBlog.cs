using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class S2_EventBlog
{
    [Key]
    public int seq { get; set; }

    [StringLength(2)]
    [Unicode(false)]
    public string sales_gubun { get; set; } = null!;

    public int company_seq { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string uid { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string blog_url { get; set; } = null!;

    [Column(TypeName = "text")]
    public string q_comment { get; set; } = null!;

    [Column(TypeName = "text")]
    public string? a_comment { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string provide { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string? provide_no { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime reg_date { get; set; }
}
