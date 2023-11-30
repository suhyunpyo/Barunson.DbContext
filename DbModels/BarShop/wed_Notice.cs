using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Barunson.DbContext.DbModels.BarShop;

[Keyless]
public partial class wed_Notice
{
    public int seq { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string name { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string title { get; set; } = null!;

    [Column(TypeName = "text")]
    public string contents { get; set; } = null!;

    public int viewcnt { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string sales_gubun { get; set; } = null!;

    public int? company_seq { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string div { get; set; } = null!;

    [Column(TypeName = "datetime")]
    public DateTime mdate { get; set; }

    public byte vlevel { get; set; }

    /// <summary>
    /// 0:전체,1:부분
    /// </summary>
    [StringLength(1)]
    [Unicode(false)]
    public string auth { get; set; } = null!;
}
