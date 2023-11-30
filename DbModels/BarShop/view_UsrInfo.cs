using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class view_UsrInfo
{
    [StringLength(15)]
    [Unicode(false)]
    public string site_name { get; set; } = null!;

    [StringLength(19)]
    [Unicode(false)]
    public string tbl_name { get; set; } = null!;

    [StringLength(16)]
    [Unicode(false)]
    public string uid { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string uname { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string pwd { get; set; } = null!;

    [StringLength(13)]
    [Unicode(false)]
    public string? jumin { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string? umail { get; set; }

    [StringLength(11)]
    [Unicode(false)]
    public string? phone { get; set; }

    [StringLength(11)]
    [Unicode(false)]
    public string? hand_phone { get; set; }

    [Column(TypeName = "datetime")]
    public DateTime? reg_date { get; set; }

    public int? company_seq { get; set; }
}
