using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

/// <summary>
/// old) 방명록
/// </summary>
public partial class SH_Notice
{
    [Key]
    public int N_num { get; set; }

    [StringLength(20)]
    [Unicode(false)]
    public string N_id { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string N_title { get; set; } = null!;

    [Column(TypeName = "text")]
    public string N_text { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime N_insdate { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string N_passwd { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string N_name { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime? org_date { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? view_div { get; set; }
}
