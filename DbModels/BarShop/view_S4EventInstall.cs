using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class view_S4EventInstall
{
    public int seq { get; set; }

    public int company_seq { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string company_name { get; set; } = null!;

    [StringLength(16)]
    [Unicode(false)]
    public string? uid { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string uname { get; set; } = null!;

    [StringLength(10)]
    [Unicode(false)]
    public string? reg_date { get; set; }

    [StringLength(13)]
    [Unicode(false)]
    public string? hphone { get; set; }

    [StringLength(251)]
    [Unicode(false)]
    public string addr { get; set; } = null!;

    [StringLength(1)]
    [Unicode(false)]
    public string? favorite_install { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? desktop_install { get; set; }

    public int? favorite_cnt { get; set; }

    public int? desktop_cnt { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isSelection { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? isUsed { get; set; }

    public int login_count { get; set; }
}
