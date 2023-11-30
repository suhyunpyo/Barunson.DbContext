using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

public partial class S4_EventOnliving_Reply
{
    [Key]
    public int seq { get; set; }

    public int company_seq { get; set; }

    public int? reg_num { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? uid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? uname { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? umail { get; set; }

    [StringLength(13)]
    [Unicode(false)]
    public string? hphone { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? order_seq { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string? vote_card { get; set; }

    [StringLength(1000)]
    [Unicode(false)]
    public string comment { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string? isDisplay { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime reg_date { get; set; }
}
