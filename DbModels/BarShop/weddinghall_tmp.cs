using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class weddinghall_tmp
{
    public int id { get; set; }

    public int order_seq { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string admin_id { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? folder { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime reg_date { get; set; }

    [Column(TypeName = "smalldatetime")]
    public DateTime? approve_date { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string status { get; set; } = null!;

    public int? wedd_idx { get; set; }

    public int? weddimg_idx { get; set; }

    public byte? wdiv { get; set; }

    public byte? location { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? wname { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string? wphone { get; set; }

    [StringLength(200)]
    [Unicode(false)]
    public string? waddress { get; set; }
}
